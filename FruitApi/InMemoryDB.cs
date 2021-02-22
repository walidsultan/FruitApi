using FruitApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FruitApi
{
    public static class InMemoryDB
    {
        public static List<Fruit> Fruit { get; set; }
    }
}