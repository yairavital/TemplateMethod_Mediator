using TemplateMethodDesignPattern;

Console.ForegroundColor = ConsoleColor.White;
ExerciseBase exerciseBase = new Child();
exerciseBase.TrainingProgram();
Console.ForegroundColor = ConsoleColor.Magenta;
ExerciseBase exerciseBase1 = new Adults();
exerciseBase1.TrainingProgram();