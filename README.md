![GitHub last commit](https://img.shields.io/github/last-commit/MindTrader/InterviewTask_Areas?style=for-the-badge)
![GitHub issues](https://img.shields.io/github/issues/MindTrader/InterviewTask_Areas?style=for-the-badge)
![GitHub repo size](https://img.shields.io/github/repo-size/MindTrader/InterviewTask_Areas?style=for-the-badge)
![GitHub code size in bytes](https://img.shields.io/github/languages/code-size/MindTrader/InterviewTask_Areas?style=for-the-badge)
![GitHub top language](https://img.shields.io/github/languages/top/MindTrader/InterviewTask_Areas?style=for-the-badge)


# Data Serialization
Данное приложение создано для решения следующей задачи:

<b>Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:

- Юнит-тесты

- Легкость добавления других фигур

- Вычисление площади фигуры без знания типа фигуры в compile-time

- Проверку на то, является ли треугольник прямоугольным.</b>

Целевая платформа - .Net Framework 4.6.1

## Описание работы библиотеки

Сам .dll файл с кодом библиотеки находится по данном пути внутри репозитория: "AreaTask/bin/Release/AreaTask.dll".

Подключив AreaTask.dll к вашему проекту, вам станет доступен следующий функционал:
- Вычисление площади круга указанного радиуса (класс `Circle`, метод `GetArea`);
- Вычисление площади треугольника с указанными сторонами (класс `Triangle`, метод `GetArea`);
- Проверка является ли треугольник прямоугольным (класс `Triangle`, метод `IsRectangular`).
 
 ## Тестирование приложения
 Для тестирования приложения было создано несколько Unit тестов, проверяющих работу методов в различных ситуациях.
 Исходный код тестов вы можете увидеть в файлах "AreaTaskTests/CircleTests.cs" и AreaTaskTests/TriangleTests.cs.

## Установка приложения
Чтобы установить приложение - запустите установочный файл "OtherFiles/ForInstallation/setup.exe" и дождитесь окончания установки. После этого на рабочем столе появится ярлык для запуска приложения "Data Serialization"
