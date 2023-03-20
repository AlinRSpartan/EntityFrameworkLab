using EntityFrameworkLab.Models;
using System.Collections.Generic;

using (var db = new AcademyContext())
{
    DropTable(db);
    InitialiseAcademy(db);
    ShowTrainees(db);
    Console.WriteLine("\nChanging Alin's location to London :\n");
    var alin = db.Trainees.Find(0);
    alin.Location = "London";
    db.SaveChanges();
    ShowTrainees(db);
    DropTable(db);
    Console.WriteLine("Dropping table: ");
    ShowTrainees(db);
}

static void InitialiseAcademy(AcademyContext db)
{

        var trainee0 = new Trainee
        {
            TraineeId = 0,
            Name = "Alin-George Rusu",
            Course = "Tech205",
            Location = "Birmingham"
        };

        var trainee1 = new Trainee
        {
            TraineeId = 1,
            Name = "Byron Esson",
            Course = "Tech205",
            Location = "Birmingham"
        };

        var trainee2 = new Trainee
        {
            TraineeId = 2,
            Name = "Chun Kai Ho",
            Course = "Tech205",
            Location = "Birmingham"
        };

        var trainee3 = new Trainee
        {
            TraineeId = 3,
            Name = "Connor Dawson",
            Course = "Tech205",
            Location = "Birmingham"
        };

        var trainee4 = new Trainee
        {
            TraineeId = 4,
            Name = "Henry Shapland",
            Course = "Tech205",
            Location = "Birmingham"
        };

        var trainee5 = new Trainee
        {
            TraineeId = 5,
            Name = "Jack Linstead",
            Course = "Tech205",
            Location = "Birmingham"
        };

        var trainee6 = new Trainee
        {
            TraineeId = 6,
            Name = "Luke Pinder",
            Course = "Tech205",
            Location = "Birmingham"
        };

        var trainee7 = new Trainee
        {
            TraineeId = 7,
            Name = "Max Hegarty",
            Course = "Tech205",
            Location = "Birmingham"
        };

        var trainee8 = new Trainee
        {
            TraineeId = 8,
            Name = "Mohammed Ali Butt",
            Course = "Tech205",
            Location = "Birmingham"
        };

        var trainee9 = new Trainee
        {
            TraineeId = 9,
            Name = "Mubashir Ahmad",
            Course = "Tech205",
            Location = "Birmingham"
        };

        var trainee10 = new Trainee
        {
            TraineeId = 10,
            Name = "Rakesh Mariappan",
            Course = "Tech205",
            Location = "Birmingham"
        };

        var trainee11 = new Trainee
        {
            TraineeId = 11,
            Name = "Ricardo Goncalves",
            Course = "Tech205",
            Location = "Birmingham"
        };

        var trainee12 = new Trainee
        {
            TraineeId = 12,
            Name = "Ruya Kumru-Holroyd",
            Course = "Tech205",
            Location = "Birmingham"
        };

        var trainee13 = new Trainee
        {
            TraineeId = 13,
            Name = "Valentin Gaudeau",
            Course = "Tech205",
            Location = "Birmingham"
        };
        List<Trainee> list = new List<Trainee> { trainee0 ,
trainee1 ,
trainee2 ,
trainee3 ,
trainee4 ,
trainee5 ,
trainee6 ,
trainee7 ,
trainee8 ,
trainee9 ,
trainee10 ,
trainee11 ,
trainee12 ,
trainee13
};
        foreach (var item in list)
        {
            db.Trainees.Add(item);
        }
        db.SaveChanges();
    
}
static void DropTable(AcademyContext db)
{
    foreach (var item in db.Trainees)
    {
        db.Trainees.Remove(item);
    }
    db.SaveChanges();
}
static void ShowTrainees(AcademyContext db)
{
    foreach(var item in db.Trainees)
        Console.WriteLine(item);
}