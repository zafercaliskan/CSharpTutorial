using System;
using System.Collections.Generic;

namespace OOP3;

class Program
{
    static void Main(string[] args)
    {
        // Interface can hold the reference of the class that implements it.

        // ICreditManager housingCreditManager = new HousingCreditManager();
        // housingCreditManager.Calculate();

        // ICreditManager personalFinanceCreditManager =new PersonalFinanceCreditManager();
        // personalFinanceCreditManager.Calculate();

        // ICreditManager vehicleCreditManager = new VehicleCreditManager();
        // vehicleCreditManager.Calculate();


        ICreditManager housingCreditManager = new HousingCreditManager();
        ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
        ICreditManager vehicleCreditManager = new VehicleCreditManager();

        ILoggerService databaseLoggerService = new DatabaseLoggerService();
        ILoggerService fileLoggerService = new FileLoggerService();
        ILoggerService smsLoggerService = new SmsLoggerService();
        

        List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };
        
        ApplicationManager applicationManager = new ApplicationManager();
        // Important point. MakeApplication(ICreditManager) means it can take HousingCreditManager, PersonalFinanceCreditManager, VehicleCreditManager.
                  
        // Here we could have sent personal finance instead of vehicle credit or any credit type or any logger type
        // This ensures sustainability in the software.
        applicationManager.MakeApplication(new TradesmanCreditManager(), loggers);

        List<ICreditManager> credits = new List<ICreditManager>() { housingCreditManager, vehicleCreditManager };
        applicationManager.ProvidePreliminaryInfo(credits);

        // Proof of sustainability: SOLID (O) -> When new code is added to the system, existing codes do not break.
        // You add tradesman credit, it inherits from ICreditManager. And it implements, we write calculate codes.
        // When adding Sms logger, it inherits from ILoggerService. It implements Log method, writes its codes and we use it. 
        // And we don't need to make changes anywhere.

    }
}