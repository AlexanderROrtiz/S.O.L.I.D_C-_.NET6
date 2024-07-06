using SingleResponsability;

StudentRepository studentRepository = new();
ExportHelper exportHelper = new();
exportHelper.ExportEstudents(studentRepository.GetAll());
Console.WriteLine("Proceso Completado");