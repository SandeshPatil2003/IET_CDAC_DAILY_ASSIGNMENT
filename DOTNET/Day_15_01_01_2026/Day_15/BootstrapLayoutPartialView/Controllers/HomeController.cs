using BootstrapLayoutPartialView.Models;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapLayoutPartialView.Controllers
{
    public class HomeController : Controller
    {

        List<Student> students = new List<Student>(){

                        new Student (){Id=1,Name="John Cena",Email="john@gmail.com",Phone="738134728",AdmissionDate=new DateOnly(2026,01,01) ,Percentage= 99 },
                        new Student (){Id=2,Name="Jane Doe",Email="jane@gmail.com",Phone="987654321",AdmissionDate=new DateOnly(2026,01,05) ,Percentage= 85 },
                    new Student (){Id=3,Name="Peter Parker",Email="peter.p@marvel.com",Phone="123450987",AdmissionDate=new DateOnly(2026,01,15) ,Percentage= 76 },
                    new Student (){Id=4,Name="Bruce Wayne",Email="bruce@wayneenterprises.com",Phone="999888777",AdmissionDate=new DateOnly(2026,02,01) ,Percentage= 92 },
                    new Student (){Id=5,Name="Clark Kent",Email="clark@dailyplanet.com",Phone="111222333",AdmissionDate=new DateOnly(2026,02,10) ,Percentage= 88 },
                    new Student (){Id=6,Name="Diana Prince",Email="diana@amazon.com",Phone="444555666",AdmissionDate=new DateOnly(2026,02,28) ,Percentage= 95 },
                    new Student (){Id=7,Name="Tony Stark",Email="tony@starkindustries.com",Phone="777999111",AdmissionDate=new DateOnly(2026,03,05) ,Percentage= 81 },
                    new Student (){Id=8,Name="Natasha Romanoff",Email="natasha@shield.com",Phone="555444333",AdmissionDate=new DateOnly(2026,03,12) ,Percentage= 89 },
                    new Student (){Id=9,Name="Steve Rogers",Email="steve@avengers.com",Phone="222333444",AdmissionDate=new DateOnly(2026,03,20) ,Percentage= 79 },
                    new Student (){Id=10,Name="Wanda Maximoff",Email="wanda@sokovia.net",Phone="888999000",AdmissionDate=new DateOnly(2026,04,01) ,Percentage= 91 },
                    new Student (){Id=11,Name="Vision",Email="vision@synth.net",Phone="000111222",AdmissionDate=new DateOnly(2026,04,15) ,Percentage= 98 },
                    new Student (){Id=12,Name="Barry Allen",Email="barry@centralcity.pd",Phone="555019283",AdmissionDate=new DateOnly(2026,04,20) ,Percentage= 87 },
new Student (){Id=13,Name="Arthur Curry",Email="arthur@atlantis.org",Phone="888222333",AdmissionDate=new DateOnly(2026,05,01) ,Percentage= 74 },
new Student (){Id=14,Name="Hal Jordan",Email="hal@coastcity.air",Phone="101010101",AdmissionDate=new DateOnly(2026,05,10) ,Percentage= 82 },
new Student (){Id=15,Name="Scott Lang",Email="scott@pymtech.com",Phone="456789123",AdmissionDate=new DateOnly(2026,05,25) ,Percentage= 68 },
new Student (){Id=16,Name="T'Challa",Email="king@wakanda.gov",Phone="000999888",AdmissionDate=new DateOnly(2026,06,01) ,Percentage= 97 },
new Student (){Id=17,Name="Carol Danvers",Email="carol@starforce.mil",Phone="321654987",AdmissionDate=new DateOnly(2026,06,12) ,Percentage= 94 },
new Student (){Id=18,Name="Stephen Strange",Email="doctor@sanctum.com",Phone="999000111",AdmissionDate=new DateOnly(2026,06,20) ,Percentage= 99 },
new Student (){Id=19,Name="Logan Howlett",Email="logan@xmen.edu",Phone="666555444",AdmissionDate=new DateOnly(2026,07,04) ,Percentage= 70 },
new Student (){Id=20,Name="Charles Xavier",Email="professor@xmen.edu",Phone="111000111",AdmissionDate=new DateOnly(2026,07,15) ,Percentage= 100 },
new Student (){Id=21,Name="Matt Murdock",Email="matt@nelsonandmurdock.com",Phone="202555010",AdmissionDate=new DateOnly(2026,08,01) ,Percentage= 93 }
                };
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AllStudents()
         {
                   
            return View(students);
        }
    }
}
