﻿using System;

    public class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        private int age;

        // propfull public int Age
        //  {
        //      get { return _age; }
        //      set { _age = value; }
        //  }

        public int Test()
        {
            return 7;
        }
        public string AnotherTest()
        {
            return "test";
        }
        public void AnotherTestTest()
        {
            Employee e = new Employee();
            {
                FirstName = "Erick";
                LastName = "Negrete";
                e.age = 23;
            };
            int expected = 23;

            e.age = 23;

            Assert.AreEqual(expected, e.age);
        }
    }