using ECF_LEGUMOS_CARRIVALE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECF_LEGUMOS_CARRIVALE.Data
{
    public class DbInitializer
    {
        public static void Initialize(LegumosContext context)
        {


            context.Database.EnsureCreated();


            if (context.Vegetables.Any())
            {
                return;
            }

            var vegetables = new Vegetable[]
            {


                new Vegetable{Name="Chou", Variety="Frisé", PrimaryColor="vert", LifeTime=30, Fresh=0},
                new Vegetable{Name="Poireau", Variety="Carlton", PrimaryColor="vert clair", LifeTime=20, Fresh=0},
                new Vegetable{Name="Carotte", Variety="Nantaise", PrimaryColor="orange", LifeTime=90, Fresh=0}

            };

            foreach (Vegetable c in vegetables)
            {
                context.Vegetables.Add(c);
            }
            context.SaveChanges();





            if (context.Sales.Any())
            {
                return;
            }

            var sales = new Sale[]
            {
                new Sale{SaleDate= new DateTime(2020, 2, 3, 2, 30, 0), SaleWeight=15, SaleUnitPrice=Decimal.Add(00001, .01m), SaleActive=1, VegetableId=1},
                new Sale{ SaleDate= new DateTime(2020, 2, 4, 7, 47, 0), SaleWeight=7, SaleUnitPrice=Decimal.Add(00001, .10m), SaleActive=1, VegetableId=1},
                new Sale{SaleDate= new DateTime(2020, 2, 4, 7, 47, 0), SaleWeight=23, SaleUnitPrice=Decimal.Add(00001, .80m), SaleActive=1, VegetableId=3},
                new Sale{SaleDate= new DateTime(2020, 2, 6, 7, 47, 0), SaleWeight=9, SaleUnitPrice=Decimal.Add(00001, .50m), SaleActive=1, VegetableId=1},
                new Sale{SaleDate= new DateTime(2020, 2, 7, 7, 47, 0) , SaleWeight=8, SaleUnitPrice=Decimal.Add(00001, .20m), SaleActive=1, VegetableId=2},
                new Sale{SaleDate= new DateTime(2020, 2, 9, 7, 47, 0) , SaleWeight=23, SaleUnitPrice=Decimal.Add(00001, .40m), SaleActive=1, VegetableId=3},
                new Sale{SaleDate= new DateTime(2020, 15, 2, 7, 47, 0) , SaleWeight=5, SaleUnitPrice=Decimal.Add(00001, .30m), SaleActive=1, VegetableId=1},
                new Sale{SaleDate= new DateTime(2020, 15, 2, 7, 47, 0) , SaleWeight=11, SaleUnitPrice=Decimal.Add(00001, .60m), SaleActive=1, VegetableId=3}



            };


            foreach (Sale c in sales)
            {
                context.Sales.Add(c);
            }
            context.SaveChanges();












        }

    } 


}
