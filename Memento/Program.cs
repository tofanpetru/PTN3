using Memento.Application;
using Memento.Domain;

List<Memento.Domain.Memento> savedDataContexts = new();
MementoManager mementoManager = new();

mementoManager.SetContext(new GameProductContext("User 1", "Game 11"));
mementoManager.SetContext(new GameProductContext("User 2", "Game 22"));
savedDataContexts.Add(mementoManager.SaveToMomento());

mementoManager.SetContext(new GameProductContext("User 3", "Game 11"));
savedDataContexts.Add(mementoManager.SaveToMomento());

mementoManager.SetContext(new GameProductContext("User 4", "Game 22"));
mementoManager.RestoreFromMemento(savedDataContexts.FirstOrDefault());

Console.ReadKey();