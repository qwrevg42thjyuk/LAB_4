using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4
{
    internal class Class1
    {
    }
}
using System;
using System.Collections.Generic;

// Завдання 1: Система моделювання екосистеми

class LivingOrganism
{
    // Характеристики енергії, віку, розміру
}

interface IReproducible
{
    // Метод для розмноження
}

interface IPredator
{
    // Метод для полювання
}

class Animal : LivingOrganism, IReproducible, IPredator
{
    // Унікальні характеристики для тварин
}

class Plant : LivingOrganism, IReproducible
{
    // Унікальні характеристики для рослин
}

class Microorganism : LivingOrganism, IReproducible, IPredator
{
    // Унікальні характеристики для мікроорганізмів
}

class Ecosystem
{
    // Моделює взаємодію різних організмів
}

// Завдання 2: Умовна комп'ютерна мережа

class Computer
{
    // Властивості для IP-адреси, потужності, типу ОС
}

interface IConnectable
{
    // Методи для з'єднання та передачі даних
}

class Server : Computer, IConnectable
{
    // Унікальні характеристики для серверів
}

class Workstation : Computer, IConnectable
{
    // Унікальні характеристики для робочих станцій
}

class Router : Computer, IConnectable
{
    // Унікальні характеристики для маршрутизаторів
}

class Network
{
    // Моделює взаємодію між різними комп'ютерами
}

// Завдання 3*: Система для моделювання трафіку у місті (опційне завдання)

class Road
{
    // Інформація про дорогу, її довжину, ширину, кількість смуг, рівень трафіку і т. д.
}

class Vehicle : IDriveable
{
    // Характеристики транспортного засобу, швидкість, розмір, тип
}

interface IDriveable
{
    // Методи для руху транспортних засобів
}

// (А) Клас для імітації руху та зміни руху транспортних засобів

// (Б) Клас "Симуляція" для моделювання трафіку та оптимізації
