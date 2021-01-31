using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };

            IEat[] eats = new IEat[2]
            {
                new Manager(),
                new Worker()
            };
        }
    }

    //SOLID Interface Segregation
    interface IWorker
    {
        void Work();
    }

    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    //Classlardan birden fazla interface'i implemente edebilir. 
    class Manager : IWorker, IEat, ISalary
    {
        void IWorker.Work()
        {
            throw new NotImplementedException();
        }
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }
    }
    class Worker : IWorker, IEat, ISalary
    {
        void IWorker.Work()
        {
            throw new NotImplementedException();
        }
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}