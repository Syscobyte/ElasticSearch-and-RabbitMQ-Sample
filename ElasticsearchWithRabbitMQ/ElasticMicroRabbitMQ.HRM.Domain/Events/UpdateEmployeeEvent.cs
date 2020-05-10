﻿using ElasticMicroRabbitMQ.Domain.Core.Events;

namespace ElasticMicroRabbitMQ.HRM.Domain.Events
{
    public class UpdateEmployeeEvent : Event
    {
        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public int Salary { get; private set; }

        public UpdateEmployeeEvent(int id, string firstName, string lastName, int age, int salary)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }
    }
}
