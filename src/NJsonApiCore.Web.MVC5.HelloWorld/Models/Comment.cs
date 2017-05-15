﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace NJsonApi.Web.MVC5.HelloWorld.Models
{
    public class Comment
    {
        public Comment()
        {
            Id = StaticPersistentStore.GetNextId();
        }

        public Comment(string body)
        {
            Id = StaticPersistentStore.GetNextId();
            Body = body;
        }

        public int Id { get; set; }

        public string Body { get; set; }

        public Person Author { get; set; }
    }
}