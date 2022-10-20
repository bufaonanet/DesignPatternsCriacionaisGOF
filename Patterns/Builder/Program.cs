
using Builder;

//Instancia do Builder
NoteBookBuilder noteBookBuilder = new();
DesktopBuilder desktopBuilder = new();

//cria objetos conforme o builder
Fabricante.Build(noteBookBuilder);
Fabricante.Build(desktopBuilder);

Console.ReadLine();
