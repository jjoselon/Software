using System;

namespace SampleApp {
    // https://www.tutorialspoint.com/csharp/csharp_events.htm
   public delegate string MyDel(string str);
	
   class EventProgram {
      event MyDel MyEvent;
		
      public EventProgram() {
          // Delega (da una función o responsabilidad) a WelcomeUser como callback/handler del evento
          // [MyEvent] cuando este sea invocado/llamado
         this.MyEvent += new MyDel(this.WelcomeUser); // Suscribe WelcomeUser al evento (+=)
      }
		
      public string WelcomeUser(string username) {
         return "Welcome " + username;
      }
		
      static void Main(string[] args) {
         EventProgram obj1 = new EventProgram();
         string result = obj1.MyEvent("Tutorials Point");
         Console.WriteLine(result);
      }

   }
}