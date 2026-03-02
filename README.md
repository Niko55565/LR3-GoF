# ЛР №3 — Factory Method (Этап 1)

## Цель и задание
См. методичку: ЛР №3 «Фабричный метод и Абстрактная фабрика». fileciteturn0file0

Приложение WPF создаёт 3 фигуры (круг, квадрат, треугольник). Цвет выбирается из ComboBox. При смене цвета старые фигуры удаляются и создаются новые.

## Реализация (Factory Method)
- **Product**: `Figure` (абстрактный класс), конкретные продукты: `Circle`, `Square`, `Triangle`.
- **Creators**: три параллельные иерархии:
  - `CircleCreator` → `RedCircleCreator`, `BlueCircleCreator`, `GreenCircleCreator`
  - `SquareCreator` → `RedSquareCreator`, `BlueSquareCreator`, `GreenSquareCreator`
  - `TriangleCreator` → `RedTriangleCreator`, `BlueTriangleCreator`, `GreenTriangleCreator`
- **Клиент (MainWindow)** выбирает создателей через `switch`, затем создаёт фигуры и добавляет их `UIElement` в панель.

## Анализ
Плюс: создание объектов отделено от использования.  
Минус: много параллельных иерархий и дублирование при добавлении нового цвета (нужно 3 новых класса).

## Контрольные вопросы (кратко)
1) Factory Method создаёт один продукт через наследование Creator; Abstract Factory создаёт семейство продуктов через общий интерфейс фабрики.
2) Много иерархий потому что для каждого типа продукта отдельный Creator; ответственность размазывается по семействам цветов.
