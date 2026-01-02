using System;

namespace AbstractClasses
{
    //Interface: Our goal is to create signatures and make the classes implementing them write them again, making it mandatory.
    //VirtualMethods: Anyone who wanted could override the methods they wanted.
    //AbstractClasses: These are also a class. We can think of this as a combination of interfaces and virtual methods.
    //It is used purely for inheritance purposes. When we combine the reasons for using interfaces and virtual methods, the purpose is the same in abstract classes.

    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Oracle(); //We cannot instantiate Database here. (abstract classes cannot be instantiated)
            //So abstract classes cannot be 'new'ed.
            database.Add();
            database.Delete(); //Oracle's delete runs.

            Database database2 = new SqlServer();
            database2.Add();
            database2.Delete(); //Sql server delete runs.

            //Abstract classes are an inheritance. SqlServer can inherit from only 1 abstract class.
            //It cannot inherit from another class or abstract class. If there are other interfaces, they can be implemented.
        }

        abstract class Database
        {
            //Completed methods
            public void Add() //Add is same in all.
            {
                Console.WriteLine("Added by default");
            }

            //Incomplete methods
            public abstract void Delete(); //Delete operation is different for each database.


            //Note: We can have both complete and incomplete methods. 
        }

        class SqlServer : Database
        {
            public override void Delete()
            {
                Console.WriteLine("Deleted by sql server");
            }
        }

        class Oracle : Database
        {
            public override void Delete()  //we override the incomplete method.
            {
                Console.WriteLine("Deleted by oracle");
            }
        }
    }
}