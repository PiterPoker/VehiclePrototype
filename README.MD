<details>
  <summary>Русский</summary>

# VehiclePrototype: Реализация паттерна "Прототип"

Этот проект демонстрирует паттерн проектирования "Прототип" в C#. Моделируются различные типы транспортных средств (автобус, трамвай, троллейбус, такси), и реализуются механизмы клонирования.

## Описание проекта

Цель состоит в создании иерархии классов, которые реализуют функциональность клонирования объектов с использованием паттерна проектирования "Прототип". Включает создание пользовательского интерфейса (`ICustomCloneable`) и стандартного интерфейса `.NET` `ICloneable`. Проект включает демонстрационную программу, показывающую возможности клонирования для каждого типа транспортных средств.

## Иерархия классов

Проект использует следующую иерархию классов:

* **`Vehicle` (Абстрактный базовый класс):** Представляет основные свойства всех транспортных средств (VehicleId, Model, YearOfManufacture, Color, Length, Width, Height). Предоставляет реализацию глубокого клонирования по умолчанию, которая увеличивает значение `VehicleId` для вновь созданных клонов. Также реализует `ICustomCloneable<Vehicle>` и `ICloneable`.

* **`PublicTransport` (Абстрактный класс):** Наследуется от класса `Vehicle`. Добавляет свойства, специфичные для общественного транспорта (Route, Schedule). Реализует измененное глубокое клонирование, которое аннулирует свойства Route и Schedule для согласованности.

* **`Bus` (Конкретный класс):** Наследуется от класса `PublicTransport`. Представляет автобус и не имеет дополнительных свойств.

* **`Tram` (Конкретный класс):** Наследуется от класса `PublicTransport`. Представляет трамвай и добавляет свойство `NumCarriages`.

* **`Trolleybus` (Конкретный класс):** Наследуется от класса `PublicTransport`. Представляет троллейбус и добавляет свойство `PowerSource`.

* **`Taxi` (Конкретный класс):** Наследуется от класса `Vehicle`. Представляет такси и добавляет свойства `DriverName` и `IsAvailable`.

## Интерфейсы

* **`ICustomCloneable<T>`:** Пользовательский дженерик интерфейс, определяющий метод `CustomClone()` для создания глубоких копий объектов.

* **`ICloneable`:** Стандартный интерфейс для клонирования объектов.

## Реализация клонирования

Каждый класс транспортного средства реализует как `ICustomCloneable<Vehicle>`, так и `ICloneable`. Метод `CustomClone()` предоставляет механизм глубокого клонирования. Метод `Clone()` предлагает стандартное поверхностное копирование объектов.

## Программа демонстрации

Файл `Program.cs` демонстрирует функциональность клонирования. Он создает экземпляры каждого типа транспортного средства, клонирует их с использованием методов `CustomClone()` и `Clone()`, и модифицирует клонированные объекты, чтобы показать, что они являются независимыми. Результаты показывают данные оригинальных и клонированных транспортных средств.

## Преимущества и недостатки интерфейсов

**`ICustomCloneable<T>`:**

* **Преимущества:** Позволяет больше контролировать процесс клонирования (глубокое клонирование с конкретной обработкой свойств). Типобезопасность благодаря дженерикам.

* **Недостатки:** Требует ручной реализации для каждого класса, добавляя накладные расходы на разработку. Не является стандартным интерфейсом, что может затруднить понимание и использование другими разработчиками.

**`ICloneable`:**

* **Преимущества:** Стандартный интерфейс, широко понятен разработчикам `.NET`. Требует меньше усилий при кодировании, так как использует существующую функциональность `.NET`.

* **Недостатки:** По умолчанию предоставляет только поверхностное клонирование, что может привести к непредвиденным побочным эффектам, если не быть осторожным. Меньший контроль над процессом клонирования по сравнению с пользовательским решением.

## Тестирование

Демонстрационная программа служит основным тестом функциональности клонирования. Можно добавить более робастные модульные тесты, чтобы охватить крайние случаи и убедиться в корректности механизма клонирования.

## Стиль кода и архитектура

Код следует согласованным соглашениям об именах и использует XML комментарии документации для лучшей читаемости и удобства сопровождения. Архитектура хорошо структурирована, с четким разделением ответственности между базовыми классами, конкретными классами и определениями интерфейсов.

</details>
<details>
  <summary>English</summary>

# VehiclePrototype: Prototype Pattern Implementation

This project demonstrates the Prototype design pattern in C#.  It models different types of vehicles (Bus, Tram, Trolleybus, Taxi) and implements custom and standard cloning mechanisms.

## Project Description

The goal is to create a hierarchy of classes that implement cloning functionality using the Prototype pattern.  This involves creating a custom generic interface (`IMyCloneable`, renamed to `ICustomCloneable` for better consistency with standard naming conventions) and utilizing the standard `.NET` `ICloneable` interface.  The project includes a demonstration program showcasing the cloning capabilities of each vehicle type.


## Class Hierarchy

The project uses the following class hierarchy:

* **`Vehicle` (Abstract Base Class):**  Represents the base properties of all vehicles (VehicleId, Model, YearOfManufacture, Color, Length, Width, Height).  It provides a default implementation of deep cloning that increments the `VehicleId` for newly created clones.  It also implements `ICustomCloneable<Vehicle>` and `ICloneable`.

* **`PublicTransport` (Abstract Class):** Inherits from `Vehicle` and adds properties specific to public transport (Route, Schedule).  It implements a modified deep cloning that nullifies Route and Schedule properties for consistency.

* **`Bus` (Concrete Class):** Inherits from `PublicTransport`. Represents a bus and has no additional properties.

* **`Tram` (Concrete Class):** Inherits from `PublicTransport`.  Represents a tram and adds the `NumCarriages` property.

* **`Trolleybus` (Concrete Class):** Inherits from `PublicTransport`. Represents a trolleybus and adds the `PowerSource` property.

* **`Taxi` (Concrete Class):** Inherits from `Vehicle`. Represents a taxi and adds `DriverName` and `IsAvailable` properties.


## Interfaces

* **`ICustomCloneable<T>`:** A custom generic interface defining a `CostumClone()` method for creating deep copies of objects. The name should be corrected to `ICustomCloneable` to be consistent with general coding style conventions.

* **`ICloneable`:** The standard .NET interface for cloning objects.


## Cloning Implementation

Each vehicle class implements both `ICustomCloneable<Vehicle>` and `ICloneable`. The `CostumClone()` method provides a custom deep cloning mechanism. This ensures that all object properties are copied, creating independent copies of the objects, even those containing references to other objects. The `Clone()` method offers a standard shallow copy of the objects.



## Demonstration Program

The `Program.cs` file demonstrates the cloning functionality. It creates instances of each vehicle type, clones them using both `CostumClone()` and `Clone()`, and modifies the cloned objects to show that they are independent. The output shows the original and cloned vehicle data.


## Advantages and Disadvantages of Interfaces

**`ICustomCloneable<T>`:**

* **Advantages:** Allows for more control over the cloning process (deep cloning with specific property handling).  Type-safe due to generics.

* **Disadvantages:** Requires manual implementation for each class, adding development overhead.  Not a standard interface, potentially reducing familiarity for developers.

**`ICloneable`:**

* **Advantages:**  Standard interface; widely understood by .NET developers. Requires less coding effort as it leverages the existing functionality provided by `.NET`.

* **Disadvantages:**  Provides only shallow cloning by default, potentially leading to unintended side effects if not handled carefully.  Less control over the cloning process compared to a custom solution.




## Testing

The demonstration program serves as a basic test of the cloning functionality.  More robust unit tests could be added to cover edge cases and ensure the correctness of the cloning mechanism.


## Code Style and Architecture

The code follows consistent naming conventions and uses XML documentation comments for better readability and maintainability. The architecture is well-structured, with clear separation of concerns between the base classes, concrete classes, and the interface definitions.

</details>