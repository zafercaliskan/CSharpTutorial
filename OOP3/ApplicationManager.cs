using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3;

class ApplicationManager
{
    // (ICreditManager creditManager, List<ILoggerService> loggerServices) - dependency injection
    // Method injection -> meaning we inject which credit type it will be and which logger it will be.
    public void MakeApplication(ICreditManager creditManager, List<ILoggerService> loggerServices)            
    {
        // Here in my application operations, there is no info on which credit, which logger. Only abstract versions exist, we inject concrete versions.

        // HousingCreditManager housingCreditManager = new HousingCreditManager(); Wrong usage.
        // Correct usage. Whichever of Vehicle, Housing, Personal Finance credit comes here, 
        // the reference of that one's calculate method in memory works.
        creditManager.Calculate();
        foreach (var loggerService in loggerServices)
        {
            loggerService.Log();
        }
    }

    public void ProvidePreliminaryInfo(List<ICreditManager> credits)
    {
        foreach (var credit in credits)
        {
            credit.Calculate();
        }
    }
}
