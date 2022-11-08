StartChoice();

/// <summary>
/// Ответ
/// </summary>
string answer;

/// <summary>
/// Начальный выбор
/// </summary>
void StartChoice()
{
    Console.Clear();
    Console.WriteLine("Нужен компаньон по жизни или просто сосед по комнате?\n1 - Компаньон\n2 - Сосед по комнате");
    answer = Console.ReadLine();
    if (answer == "1")
        Console.WriteLine("Вам подойдет - Собака");
    else if (answer == "2")
        AmountOfWool();
    else
    {
        Console.Clear();
        StartChoice();
    }
}

/// <summary>
/// Количество шерсти
/// </summary>
void AmountOfWool()
{
    Console.WriteLine("Вы будете возражать, если придется всё время убирать шерсть?\n1 - НЕТ! Пушистики ТОП!\n2 - ФУ! Шерсть\n3 - *Начать с самого начала*");
    answer = Console.ReadLine();
    if (answer == "1")
        FetidOdors();
    else if (answer == "2")
        NumberOfLegs();
    else if (answer == "3")
        StartChoice();
    else
    {
        Console.Clear();
        AmountOfWool();
    }
}

/// <summary>
/// Зловонные запахи
/// </summary>
void FetidOdors()
{
    Console.WriteLine("Вы хорошо переносите зловонные запахи?\n1 - Без запаха!\n2 - Я тоже слегка воняю, поэтому мы уживемся\n3 - *Начать с самого начала*");
    answer = Console.ReadLine();
    if (answer == "1")
        ScratchBite();
    else if (answer == "2")
        Console.WriteLine("Вам подойдет - Хорек");
    else if (answer == "3")
        StartChoice();
    else
    {
        Console.Clear();
        FetidOdors();
    }
}

/// <summary>
/// Царапкать и кусать
/// </summary>
void ScratchBite()
{
    Console.WriteLine("Вы хотите чтобы вас царапали или кусали?\n1 - И то и другое\n2 - Пусть только кусает\n3 - *Начать с самого начала*");
    answer = Console.ReadLine();
    if (answer == "1")
        Console.WriteLine("Вам подойдет - Кошка");
    else if (answer == "2")
        Console.WriteLine("Вам подойдет - Кролик");
    else if (answer == "3")
        StartChoice();
    else
    {
        Console.Clear();
        ScratchBite();
    }
}

/// <summary>
/// Количество ног
/// </summary>
void NumberOfLegs()
{
    Console.WriteLine("Со сколькими ногами ты справишься?\n1 - Без ног\n2 - 2 ноги\n3 - 4 ноги\n4 - Чем больше, тем лучше\n5 - *Начать с самого начала*");
    answer = Console.ReadLine();
    if (answer == "1")
        BuyingMice();
    else if (answer == "2")
        Console.WriteLine("Вам подойдет - Птица");
    else if (answer == "3")
        WarmColdBlooded();
    else if (answer == "4")
        Console.WriteLine("Вам подойдет - Тарантул");
    else if (answer == "5")
        StartChoice();
    else
    {
        Console.Clear();
        NumberOfLegs();
    }
}

/// <summary>
/// Покупка мышей
/// </summary>
void BuyingMice()
{
    Console.WriteLine("Как насчет того, чтобы покупать мертвых мышей каждый месяц?\n1 - Звучит круто!\n2 - Неее\n3 - *Начать с самого начала*");
    answer = Console.ReadLine();
    if (answer == "1")
        Console.WriteLine("Вам подойдет - Змея");
    else if (answer == "2")
        Console.WriteLine("Вам подойдет - Рыбка");
    else if (answer == "3")
        StartChoice();
    else
    {
        Console.Clear();
        BuyingMice();
    }
}

/// <summary>
/// Тепло- и хладнокровные
/// </summary>
void WarmColdBlooded()
{
    Console.WriteLine("Хладнокровное или теплокровное?\n1 - Люблю погорячее!!!\n2 - Словно лёд\n3 - *Начать с самого начала*");
    answer = Console.ReadLine();
    if (answer == "1")
        TailChoice();
    else if (answer == "2")
        ManRush();
    else if (answer == "3")
        StartChoice();
    else
    {
        Console.Clear();
        WarmColdBlooded();
    }
}

/// <summary>
/// Выбор хвоста
/// </summary>
void TailChoice()
{
    Console.WriteLine("Какой тип хвоста вы предпочитаете?\n1 - Без хвоста\n2 - Длинный и пушистый\n3 - Как большой дождевой червь!!!\n4 - *Начать с самого начала*");
    answer = Console.ReadLine();
    if (answer == "1")
        Spikes();
    else if (answer == "2")
        Console.WriteLine("Вам подойдет - Песчанка");
    else if (answer == "3")
        Console.WriteLine("Вам подойдет - Крыса");
    else if (answer == "4")
        StartChoice();
    else
    {
        Console.Clear();
        TailChoice();
    }
}

/// <summary>
/// Шипы
/// </summary>
void Spikes()
{
    Console.WriteLine("Может тогда шипы??\n1 - Да, а почему бы и нет?\n2 - Ну нафиг!\n3 - *Начать с самого начала*");
    answer = Console.ReadLine();
    if (answer == "1")
        Console.WriteLine("Вам подойдет - Ёж");
    else if (answer == "2")
        Console.WriteLine("Вам подойдет - Хомяк");
    else if (answer == "3")
        StartChoice();
    else
    {
        Console.Clear();
        Spikes();
    }
}

/// <summary>
/// Человек-спешка
/// </summary>
void ManRush()
{
    Console.WriteLine("Вы человек-спешка?\n1 - Не-а\n2 - Ага\n3 - *Начать с самого начала*");
    answer = Console.ReadLine();
    if (answer == "1")
        Console.WriteLine("Вам подойдет - Черепаха");
    else if (answer == "2")
        Console.WriteLine("Вам подойдет - Ящерица");
    else if (answer == "3")
        StartChoice();
    else
    {
        Console.Clear();
        ManRush();
    }
}