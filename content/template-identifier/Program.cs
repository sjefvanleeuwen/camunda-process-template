using System;
using System.Threading;
using CamundaClient;

namespace template_identifier {
    class Program
    {
private static string logo = @"
 __      __.___  ________________     _____ .______________ 
/  \    /  |   |/  _____/\_____  \   /  |  ||   \__    ___/ 
\   \/\/   |   /   \  ___ /   |   \ /   |  ||   | |    |    
 \        /|   \    \_\  /    |    /    ^   |   | |    |    
  \__/\  / |___|\______  \_______  \____   ||___| |____|    
       \/              \/        \/     |__|                
       
template-identifier camunda processes";

        private static readonly AutoResetEvent _closing = new AutoResetEvent(false);
        private static void Main(string[] args)
        {
            
            Console.WriteLine( logo + "\n\n" + "Deploying models and start External Task Workers.\n\nPRESS Ctrl-C TO STOP WORKERS.\n\n");

            CamundaEngineClient camunda = new CamundaEngineClient();            
            camunda.Startup(); // Deploys all models to Camunda and Start all found ExternalTask-Workers
            Console.CancelKeyPress += new ConsoleCancelEventHandler(OnExit);
            _closing.WaitOne();
            camunda.Shutdown(); // Stop Task Workers
        }

        protected static void OnExit(object sender, ConsoleCancelEventArgs args)
        {
        Console.WriteLine("Exit");
        _closing.Set();
        }

        private static void writeTasksToConsole(CamundaEngineClient camunda)
        {
            var tasks = camunda.HumanTaskService.LoadTasks();
            foreach (var task in tasks)
            {
                Console.WriteLine(task.Name);
            }
        }
    }
}
