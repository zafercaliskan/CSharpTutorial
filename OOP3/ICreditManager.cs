using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    // CreditManager alone doesn't mean much to me. It acts as a base.
    // In cases where the signature is the same (void Calculate()) but the content is different,
    // we create it as "interface ICreditManager" instead of class CreditManager.
    // The Interface acts as my template.
    // An interface tells this: If someone uses this interface, that friend
    // must include this method (void Calculate();). There can be multiple methods.
    

    // Note: When we create an interface, the operations within that interface
    // serve as a template and reference holder for alternative systems.
    
    // We use interfaces for situations that are alternatives to each other but have different code contents.
    // Calculation exists in all credit types. It is common in all credits but their codes are different.
    // Calculation operations vary according to the type of credit.
    
    interface ICreditManager
    {
        void Calculate();

        void DoSomething();
    }

    // Example: For instance, we want to do logging in the project. Who called which operation when.
    // We can do logging with different methods. For example: We can keep it in a file. We can keep logs in a database.
    // We can send logs as SMS. Sending an SMS when an application is made for a credit is also a process, it is also a logging type.
    // Sending an email is also an alternative to logging. They all log. Their signatures are the same. But when writing to a file,
    // code for writing to file, code for writing to database, code for sending SMS, code for sending email. But the operation done in all of them is logging.
}
