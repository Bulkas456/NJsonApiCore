﻿using NJsonApi.Infrastructure;

namespace NJsonApi.Web.MVCCore.HelloWorld.Models
{
    public class Person : ObjectMetaDataContainer
    {
        public Person(string firstname, string lastname, string twitter)
        {
            Id = StaticPersistentStore.GetNextId();
            FirstName = firstname;
            LastName = lastname;
            Twitter = twitter;
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Twitter { get; set; }
    }
}