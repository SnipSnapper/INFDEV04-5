using System;
using Model;
using System.Linq;

namespace Practice
{
    class Program
    {

        static void Main(string[] args)
        {
            Projection();
        }

        static void DataInsertion()
        {           
            using (var db = new MovieContext())
            {
            }
        }
        static void Projection()
        {           
            using (var db = new MovieContext())
            {
                var projected_actors = from a in db.Actors
                                       from m in db.Movies
                                       where a.MovieId == m.Id
                                       group a by m.Title into moviegrp
                                       select moviegrp;
    
                
                foreach (var item in projected_actors)
                {
                    Console.WriteLine("+ {0} ", item.Key);
                    foreach (var actor in item){
                        Console.WriteLine("-- {0} ", actor.Name);
                    }
                }
            }
        }
        static void Join()
        {           
            using (var db = new MovieContext())
            {
            }
        }
         static void Update()
        {           
            using (var db = new MovieContext())
            {
                var update_title = from m in db.Movies
                                   where m.Id == 3
                                   select m;
                foreach (var item in update_title)
                {
                    item.Title = "The Italian Massage 3: Return of the Italian";
                    
                }
                db.SaveChanges();
                System.Console.WriteLine("title updated");
            }
        }
    }
}
