
using System;

// 1. АБСТРАКЦИЯ: Базовый суперкласс (нельзя создать напрямую через new Animal())
public abstract class Animal
{
    // 2. ИНКАПСУЛЯЦИЯ: приватное поле + публичное свойство с валидацией
    private string name;
    
    public string Name
    {
        get { return name; }
        set 
        { 
            if (!string.IsNullOrWhiteSpace(value))
                name = value; 
        }
    }

    // Конструктор суперкласса
    public Animal(string name)
    {
        Name = name;
    }

    // ПОЛИМОРФИЗМ: Виртуальный метод, который дочерние классы будут переопределять
    public virtual void MakeSound()
    {
        Console.WriteLine("Животное издает звук");
    }

    // АБСТРАКТНЫЙ МЕТОД: обязан быть реализован во всех наследниках
    public abstract void Eat();
}

// 3. НАСЛЕДОВАНИЕ: Лев наследует базовый класс Animal
public class Lion : Animal
{
    public Lion(string name) : base(name) { }

    // ПОЛИМОРФИЗМ (override): Переопределяем метод суперкласса
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} рычит: Ррррр!");
    }

    public override void Eat()
    {
        Console.WriteLine($"{Name} ест мясо.");
    }
}

// Еще один класс-наследник
public class Parrot : Animal
{
    public Parrot(string name) : base(name) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} чирикает: Чик-чирик!");
    }

    public override void Eat()
    {
        Console.WriteLine($"{Name} ест зерна.");
    }
}

class Program
{
    static void Main()
    {
        // Использование полиморфизма: массив суперкласса содержит разные объекты-наследники
        Animal[] zoo = new Animal[]
        {
            new Lion("Симба"),
            new Parrot("Кеша")
        };

        foreach (Animal animal in zoo)
        {
            // Каждое животное издаст свой уникальный звук!
            animal.MakeSound();
            animal.Eat();
            Console.WriteLine();
        }
        string str = Console.ReadLine();
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Hello, World!"+str);

    }
}
