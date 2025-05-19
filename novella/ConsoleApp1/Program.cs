using System;
using System.Threading;

public class SimpleNovelForBeginner
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Добро пожаловать в простую интерактивную новеллу!");
        Console.WriteLine("--------------------------------------------------------");

        while (true)
        {
            int currentStep = 0; 
            bool isGameOver = false; 
            while (!isGameOver)
            {
                Console.Clear(); 

                switch (currentStep)
                {
                    case 0: 
                        Console.WriteLine("Вы стоите перед старым, заброшенным особняком. Солнце садится, отбрасывая длинные тени. Что вы будете делать?");
                        Console.WriteLine("1. Войти в особняк.");
                        Console.WriteLine("2. Обойти его вокруг.");
                        Console.WriteLine("3. Уйти прочь.");

                        
                        string choice0 = Console.ReadLine();
                        if (choice0 == "1")
                        {
                            currentStep = 1; 
                        }
                        else if (choice0 == "2")
                        {
                            currentStep = 2; 
                        }
                        else if (choice0 == "3")
                        {
                            currentStep = 901; 
                        }
                        else
                        {
                            Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                            Thread.Sleep(1000); 
                        }
                        break; 

                    case 1: 
                        Console.WriteLine("Вы оказываетесь в пыльном холле. Воздух тяжелый и холодный. Скрипят половицы. Слева - большая лестница, ведущая наверх. Справа - коридор вглубь дома.");
                        Console.WriteLine("1. Подняться по лестнице.");
                        Console.WriteLine("2. Пойти по коридору направо.");
                        Console.WriteLine("3. Остаться в холле и осмотреться.");
                        Console.WriteLine("4. Попробовать вернуться ко входу."); 

                        string choice1 = Console.ReadLine();
                        if (choice1 == "1")
                        {
                            currentStep = 3; 
                        }
                        else if (choice1 == "2")
                        {
                            currentStep = 4; 
                        }
                        else if (choice1 == "3")
                        {
                            currentStep = 5; 
                        }
                        else if (choice1 == "4")
                        {
                            Console.WriteLine("Дверь захлопнулась за вами! Она теперь заперта.");
                            Thread.Sleep(2000); 
                            
                        }
                        else
                        {
                            Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                            Thread.Sleep(1000);
                        }
                        break; 

                    case 2: 
                        Console.WriteLine("Вы обходите особняк. За домом обнаруживается старый, заросший сад. В углу сада виднеется покосившаяся дверь подвала.");
                        Console.WriteLine("1. Исследовать сад.");
                        Console.WriteLine("2. Попробовать открыть дверь подвала.");
                        Console.WriteLine("3. Вернуться ко входу.");

                        string choice2 = Console.ReadLine();
                        if (choice2 == "1")
                        {
                            currentStep = 6; 
                        }
                        else if (choice2 == "2")
                        {
                            currentStep = 7; 
                        }
                        else if (choice2 == "3")
                        {
                            currentStep = 0; 
                        }
                        else
                        {
                            Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                            Thread.Sleep(1000);
                        }
                        break; 

                    case 3: 
                        Console.WriteLine("Вы поднялись по скрипучей лестнице. Вы на лестничной площадке второго этажа. Отсюда расходятся два коридора: налево и направо.");
                        Console.WriteLine("1. Пойти по коридору налево.");
                        Console.WriteLine("2. Пойти по коридору направо.");
                        Console.WriteLine("3. Спуститься обратно в холл.");

                        string choice3 = Console.ReadLine();
                        if (choice3 == "1")
                        {
                            currentStep = 8; 
                        }
                        else if (choice3 == "2")
                        {
                            currentStep = 9; 
                        }
                        else if (choice3 == "3")
                        {
                            currentStep = 1; 
                        }
                        else
                        {
                            Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                            Thread.Sleep(1000);
                        }
                        break; 

                    case 4: 
                        Console.WriteLine("Вы идете по узкому, темному коридору. Пахнет плесенью и затхлостью. Коридор заканчивается двумя дверями: одна слева, другая прямо.");
                        Console.WriteLine("1. Открыть дверь слева (Кухня).");
                        Console.WriteLine("2. Открыть дверь прямо (Столовая).");
                        Console.WriteLine("3. Вернуться в холл.");

                        string choice4 = Console.ReadLine();
                        if (choice4 == "1")
                        {
                            currentStep = 10; 
                        }
                        else if (choice4 == "2")
                        {
                            currentStep = 11; 
                        }
                        else if (choice4 == "3")
                        {
                            currentStep = 1; 
                        }
                        else
                        {
                            Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                            Thread.Sleep(1000);
                        }
                        break; 

                    case 5: 
                        Console.WriteLine("Вы осматриваете холл. В углу стоит старое пианино, покрытое паутиной. На стене висит большое, треснувшее зеркало. Под зеркалом - маленький столик с ящиком.");
                        Console.WriteLine("1. Подойти к пианино.");
                        Console.WriteLine("2. Подойти к зеркалу.");
                        Console.WriteLine("3. Попробовать открыть ящик столика.");
                        Console.WriteLine("4. Вернуться к вариантам лестницы/коридора."); 

                        string choice5 = Console.ReadLine();
                        if (choice5 == "1")
                        {
                            currentStep = 12; 
                        }
                        else if (choice5 == "2")
                        {
                            currentStep = 909; 
                        }
                        else if (choice5 == "3")
                        {
                            currentStep = 13; 
                        }
                        else if (choice5 == "4")
                        {
                            currentStep = 1; 
                        }
                        else
                        {
                            Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                            Thread.Sleep(1000);
                        }
                        break; 

                    case 6: 
                        Console.WriteLine("Заросший сад полон сорняков и диких роз. В центре сада виден старый колодец. Воздух здесь немного свежее, чем в доме.");
                        Console.WriteLine("1. Осмотреть колодец.");
                        Console.WriteLine("2. Поискать что-нибудь в зарослях.");
                        Console.WriteLine("3. Вернуться ко входу в дом.");

                        string choice6 = Console.ReadLine();
                        if (choice6 == "1")
                        {
                            currentStep = 14; 
                        }
                        else if (choice6 == "2")
                        {
                            currentStep = 15; 
                        }
                        else if (choice6 == "3")
                        {
                            currentStep = 0; 
                        }
                        else
                        {
                            Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                            Thread.Sleep(1000);
                        }
                        break; 

                    case 7: 
                        Console.WriteLine("Дверь в подвал скрипит, но открывается. Из темноты веет холодным, сырым воздухом. Ступеньки вниз выглядят ненадежно.");
                        Console.WriteLine("1. Спуститься в подвал.");
                        Console.WriteLine("2. Решить не рисковать и вернуться в сад.");

                        string choice7 = Console.ReadLine();
                        if (choice7 == "1")
                        {
                            currentStep = 16; 
                        }
                        else if (choice7 == "2")
                        {
                            currentStep = 6; 
                        }
                        else
                        {
                            Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                            Thread.Sleep(1000);
                        }
                        break; 

                    case 8: 
                        Console.WriteLine("Левый коридор наверху ведет к нескольким дверям. Кажется, это спальни. Одна из дверей приоткрыта.");
                        Console.WriteLine("1. Зайти в приоткрытую комнату."); 
                        Console.WriteLine("2. Попробовать открыть другую дверь (заперта?).");
                        Console.WriteLine("3. Вернуться на лестничную площадку.");

                        string choice8 = Console.ReadLine();
                        if (choice8 == "1")
                        {
                            currentStep = 17; 
                        }
                        else if (choice8 == "2")
                        {
                            currentStep = 18; 
                        }
                        else if (choice8 == "3")
                        {
                            currentStep = 3; 
                        }
                        else
                        {
                            Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                            Thread.Sleep(1000);
                        }
                        break; 

                    case 9: 
                        Console.WriteLine("Правый коридор наверху кажется длиннее и темнее. В конце его виднеется окно. По пути есть одна дверь.");
                        Console.WriteLine("1. Подойти к окну в конце коридора.");
                        Console.WriteLine("2. Открыть дверь по пути (Кабинет).");
                        Console.WriteLine("3. Вернуться на лестничную площадку.");

                        string choice9 = Console.ReadLine();
                        if (choice9 == "1")
                        {
                            currentStep = 19; 
                        }
                        else if (choice9 == "2")
                        {
                            currentStep = 20; 
                        }
                        else if (choice9 == "3")
                        {
                            currentStep = 3; 
                        }
                        else
                        {
                            Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                            Thread.Sleep(1000);
                        }
                        break; 

                    case 10: 
                        Console.WriteLine("Вы входите в старую кухню. Повсюду ржавая утварь и разбитая посуда. На столе лежит что-то блестящее.");
                        Console.WriteLine("1. Подойти к столу и осмотреть блестящий предмет.");
                        Console.WriteLine("2. Осмотреть кладовку рядом.");
                        Console.WriteLine("3. Выйти обратно в коридор."); 

                        string choice10 = Console.ReadLine();
                        if (choice10 == "1")
                        {
                            currentStep = 21; 
                        }
                        else if (choice10 == "2")
                        {
                            currentStep = 22; 
                        }
                        else if (choice10 == "3")
                        {
                            currentStep = 4; 
                        }
                        else
                        {
                            Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                            Thread.Sleep(1000);
                        }
                        break; 

                    case 11: 
                        Console.WriteLine("Большая столовая с массивным деревянным столом и обветшалыми стульями. Кажется, здесь давно никто не ел. В углу стоит высокий шкаф.");
                        Console.WriteLine("1. Осмотреть стол.");
                        Console.WriteLine("2. Осмотреть шкаф.");
                        Console.WriteLine("3. Вернуться в коридор."); 

                        string choice11 = Console.ReadLine();
                        if (choice11 == "1")
                        {
                            currentStep = 23; 
                        }
                        else if (choice11 == "2")
                        {
                            currentStep = 24; 
                        }
                        else if (choice11 == "3")
                        {
                            currentStep = 4; 
                        }
                        else
                        {
                            Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                            Thread.Sleep(1000);
                        }
                        break; 

                    case 12: 
                        Console.WriteLine("Пианино издает печальный, фальшивый звук, когда вы касаетесь клавиш. Под крышкой вы находите пожелтевший лист бумаги с нотами и парой чисел.");
                        Console.WriteLine("1. Взять лист бумаги (теперь он у вас).");
                        Console.WriteLine("2. Оставить лист бумаги.");
                        Console.WriteLine("3. Вернуться к осмотру холла."); 

                        string choice12 = Console.ReadLine();
                        if (choice12 == "1" || choice12 == "2" || choice12 == "3") 
                        {
                            currentStep = 5; 
                        }
                        else
                        {
                            Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                            Thread.Sleep(1000);
                        }
                        break; 

                    case 13: 
                        Console.WriteLine("Вы открываете ящик столика. В нем лежат старые письма, пожелтевшая фотография и небольшой ржавый ключ.");
                        Console.WriteLine("1. Взять ключ (теперь он у вас).");
                        Console.WriteLine("2. Оставить ключ и закрыть ящик.");
                        Console.WriteLine("3. Вернуться к осмотру холла."); 

                        string choice13 = Console.ReadLine();
                        if (choice13 == "1") 
                        {
                            Console.WriteLine("Вы взяли ржавый ключ.");
                            Thread.Sleep(1500);
                            currentStep = 5; 
                                           
                        }
                        else if (choice13 == "2" || choice13 == "3")
                        {
                            currentStep = 5; 
                        }
                        else
                        {
                            Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                            Thread.Sleep(1000);
                        }
                        break; 

                    case 14: 
                        Console.WriteLine("Вы подходите к колодцу. Он глубокий, воды не видно. Слышен только звук эха.");
                        Console.WriteLine("1. Бросить что-нибудь вниз.");
                        Console.WriteLine("2. Заглянуть поглубже.");
                        Console.WriteLine("3. Отойти от колодца."); 

                        string choice14 = Console.ReadLine();
                        if (choice14 == "1")
                        {
                            currentStep = 27; 
                        }
                        else if (choice14 == "2")
                        {
                            currentStep = 907; 
                        }
                        else if (choice14 == "3")
                        {
                            currentStep = 6; 
                        }
                        else
                        {
                            Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                            Thread.Sleep(1000);
                        }
                        break; 

                    case 15: 
                        Console.WriteLine("Вы пробираетесь сквозь колючие кусты. Натыкаетесь на старый, ржавый инструмент - садовый секатор.");
                        Console.WriteLine("1. Взять секатор (теперь он у вас).");
                        Console.WriteLine("2. Оставить его.");
                        Console.WriteLine("3. Вернуться в сад."); 

                        string choice15 = Console.ReadLine();
                        if (choice15 == "1" || choice15 == "2" || choice15 == "3") 
                        {
                            currentStep = 6; 
                        }
                        else
                        {
                            Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                            Thread.Sleep(1000);
                        }
                        break; 


                    case 16:
                        Console.WriteLine("Вы в темном, сыром подвале. Пахнет землей и гнилью. Повсюду старый хлам. Где-то вдалеке капает вода.");
                        Console.WriteLine("1. Попробовать найти источник звука капающей воды.");
                        Console.WriteLine("2. Осмотреть старые ящики.");
                        Console.WriteLine("3. Найти выход из подвала (обратно)."); 

                        string choice16 = Console.ReadLine();
                        if (choice16 == "1")
                        {
                            currentStep = 28; 
                        }
                        else if (choice16 == "2")
                        {
                            currentStep = 29; 
                        }
                        else if (choice16 == "3")
                        {
                            currentStep = 7; 
                        }
                        else
                        {
                            Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                            Thread.Sleep(1000);
                        }
                        break;

                    
                    case 17:
                        Console.WriteLine("Старая спальня. Кровать покрыта белым пыльным покрывалом. На туалетном столике стоит зеркало и лежат расчески. Окно комнаты выходит в сад.");
                        Console.WriteLine("1. Осмотреть туалетный столик.");
                        Console.WriteLine("2. Посмотреть в окно.");
                        Console.WriteLine("3. Вернуться в коридор."); 

                        string choice17 = Console.ReadLine();
                        if (choice17 == "1")
                        {
                            currentStep = 30; 
                        }
                        else if (choice17 == "2")
                        {
                            currentStep = 31; 
                        }
                        else if (choice17 == "3")
                        {
                            currentStep = 8; 
                        }
                        else
                        {
                            Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                            Thread.Sleep(1000);
                        }
                        break;

                    
                    case 18:
                        Console.WriteLine("Вы выбрали наугад одну из запертых комнат. Дверь не поддается. Вы слышите странный звук изнутри.");
                        Console.WriteLine("1. Попробовать выбить дверь.");
                        Console.WriteLine("2. Отойти от двери. Звук пугает."); 

                        string choice18 = Console.ReadLine();
                        if (choice18 == "1")
                        {
                            currentStep = 32; 
                        }
                        else if (choice18 == "2")
                        {
                            currentStep = 8; 
                        }
                        else
                        {
                            Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                            Thread.Sleep(1000);
                        }
                        break;

                    
                    case 19:
                        Console.WriteLine("Вы дошли до окна в конце верхнего правого коридора. Через него виден задний двор и лес вдалеке. Окно очень грязное, но, кажется, оно не заперто.");
                        Console.WriteLine("1. Попробовать открыть окно и вылезти.");
                        Console.WriteLine("2. Вернуться в коридор."); 

                        string choice19 = Console.ReadLine();
                        if (choice19 == "1")
                        {
                            currentStep = 906; 
                        }
                        else if (choice19 == "2")
                        {
                            currentStep = 9; 
                        }
                        else
                        {
                            Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                            Thread.Sleep(1000);
                        }
                        break;

                    
                    case 20:
                        Console.WriteLine("Вы входите в кабинет. Полки уставлены старыми книгами. На столе лежит стопка бумаг и чернильница. В углу стоит старый сейф.");
                        Console.WriteLine("1. Осмотреть книги на полках.");
                        Console.WriteLine("2. Осмотреть бумаги на столе.");
                        Console.WriteLine("3. Осмотреть сейф.");
                        Console.WriteLine("4. Вернуться в коридор."); 

                        string choice20 = Console.ReadLine();
                        if (choice20 == "1")
                        {
                            currentStep = 33; 
                        }
                        else if (choice20 == "2")
                        {
                            currentStep = 34; 
                        }
                        else if (choice20 == "3")
                        {
                            currentStep = 35; 
                        }
                        else if (choice20 == "4")
                        {
                            currentStep = 9; 
                        }
                        else
                        {
                            Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                            Thread.Sleep(1000);
                        }
                        break;

                   
                    case 21:
                        Console.WriteLine("Блестящий предмет оказался старинной серебряной ложкой. Больше на столе ничего интересного нет.");
                        Console.WriteLine("1. Забрать ложку."); 
                        Console.WriteLine("2. Оставить ложку.");
                        Console.WriteLine("3. Вернуться на кухню."); 

                        string choice21 = Console.ReadLine();
                        if (choice21 == "1" || choice21 == "2" || choice21 == "3")
                        {
                            currentStep = 10; 
                        }
                        else
                        {
                            Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                            Thread.Sleep(1000);
                        }
                        break;

                    
                    case 22:
                        Console.WriteLine("Кладовка темная и тесная. Пахнет консервами и старой едой. В дальнем углу что-то шуршит.");
                        Console.WriteLine("1. Посветить туда телефоном.");
                        Console.WriteLine("2. Закрыть кладовку. Жутковато."); 

                        string choice22 = Console.ReadLine();
                        if (choice22 == "1")
                        {
                            currentStep = 36; 
                        }
                        else if (choice22 == "2")
                        {
                            currentStep = 10; 
                        }
                        else
                        {
                            Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                            Thread.Sleep(1000);
                        }
                        break;

                    
                    case 23:
                        Console.WriteLine("На столе в столовой ничего особенного, только слой пыли. Под скатертью вы находите обрывок письма с неразборчивым почерком.");
                        Console.WriteLine("1. Попробовать прочитать обрывок.");
                        Console.WriteLine("2. Оставить обрывок.");
                        Console.WriteLine("3. Вернуться в столовую."); 

                        string choice23 = Console.ReadLine();
                        if (choice23 == "1")
                        {
                            currentStep = 37; 
                        }
                        else if (choice23 == "2" || choice23 == "3")
                        {
                            currentStep = 11; 
                        }
                        else
                        {
                            Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                            Thread.Sleep(1000);
                        }
                        break;

                    
                    case 24:
                        Console.WriteLine("Шкаф закрыт на замок. Кажется, ему нужен ключ.");
                        Console.WriteLine("1. Поискать ключ рядом (не находится)."); 
                        Console.WriteLine("2. Вернуться в столовую."); 

                        string choice24 = Console.ReadLine();
                        if (choice24 == "1")
                        {
                            Console.WriteLine("Никакого ключа поблизости нет.");
                            Thread.Sleep(1500);
                            currentStep = 11; 
                        }
                        else if (choice24 == "2")
                        {
                            currentStep = 11; 
                        }
                        else
                        {
                            Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                            Thread.Sleep(1000);
                        }
                        break;


                    
                    case 27:
                        Console.WriteLine("Вы бросили камень в колодец. Слышен только глухой удар внизу, без всплеска. Это очень странно.");
                        Console.WriteLine("1. Это странно. Уйти от колодца."); 
                        Console.WriteLine("2. Все равно заглянуть поглубже."); 

                        string choice27 = Console.ReadLine();
                        if (choice27 == "1")
                        {
                            currentStep = 6; 
                        }
                        else if (choice27 == "2")
                        {
                            currentStep = 907; 
                        }
                        else
                        {
                            Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                            Thread.Sleep(1000);
                        }
                        break;

                   
                    case 28:
                        Console.WriteLine("Вы идете на звук капающей воды. Он приводит вас к стене, из которой сочится влага. Там ничего особенного, кроме плесени.");
                        Console.WriteLine("1. Осмотреть старые ящики рядом."); 
                        Console.WriteLine("2. Найти выход из подвала (обратно)."); 

                        string choice28 = Console.ReadLine();
                        if (choice28 == "1")
                        {
                            currentStep = 29; 
                        }
                        else if (choice28 == "2")
                        {
                            currentStep = 7; 
                        }
                        else
                        {
                            Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                            Thread.Sleep(1000);
                        }
                        break;

                    case 29:
                        Console.WriteLine("Ящики полны разного хлама. В одном из них вы находите пыльную книгу с засушенным цветком внутри. В другом - старый, пустой мешок.");
                        Console.WriteLine("1. Осмотреть книгу.");
                        Console.WriteLine("2. Продолжить искать в подвале (вернуться к вариантам подвала)."); 
                        Console.WriteLine("3. Найти выход из подвала."); 

                        string choice29 = Console.ReadLine();
                        if (choice29 == "1")
                        {
                            currentStep = 38; 
                        }
                        else if (choice29 == "2")
                        {
                            currentStep = 16; 
                        }
                        else if (choice29 == "3")
                        {
                            currentStep = 7; 
                        }
                        else
                        {
                            Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                            Thread.Sleep(1000);
                        }
                        break;

                    
                    case 30:
                        Console.WriteLine("На столике лежат старые расчески и пустые флаконы от духов. В одном из ящиков вы находите запыленное ожерелье.");
                        Console.WriteLine("1. Взять ожерелье."); 
                        Console.WriteLine("2. Оставить ожерелье.");
                        Console.WriteLine("3. Вернуться в спальню."); 

                        string choice30 = Console.ReadLine();
                        if (choice30 == "1" || choice30 == "2" || choice30 == "3")
                        {
                            currentStep = 17; 
                        }
                        else
                        {
                            Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                            Thread.Sleep(1000);
                        }
                        break;

                    case 31:
                        Console.WriteLine("Из окна виден заросший сад и та самая дверь в подвал. Кажется, с этой стороны можно было бы спрыгнуть, но это опасно.");
                        Console.WriteLine("1. Попробовать спрыгнуть из окна.");
                        Console.WriteLine("2. Вернуться в комнату."); 

                        string choice31 = Console.ReadLine();
                        if (choice31 == "1")
                        {
                            currentStep = 906; 
                        }
                        else if (choice31 == "2")
                        {
                            currentStep = 17; 
                        }
                        else
                        {
                            Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                            Thread.Sleep(1000);
                        }
                        break;

                    case 32:
                        Console.WriteLine("Вы пытаетесь выбить дверь, но она слишком прочная. Шум привлекает внимание... Чего-то или кого-то изнутри.");
                        Console.WriteLine("1. Быстро убежать.");
                        Console.WriteLine("2. Замереть и прислушаться.");

                        string choice32 = Console.ReadLine();
                        if (choice32 == "1")
                        {
                            currentStep = 39; 
                        }
                        else if (choice32 == "2")
                        {
                            currentStep = 905; 
                        }
                        else
                        {
                            Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                            Thread.Sleep(1000);
                        }
                        break;

                    
                    case 33:
                        Console.WriteLine("Книги очень старые, но большинство из них по философии и истории. На одной из книг вы замечаете подчеркнутую дату: '1888'.");
                        Console.WriteLine("1. Запомнить дату '1888'."); 
                        Console.WriteLine("2. Вернуться к осмотру кабинета."); 

                        string choice33 = Console.ReadLine();
                        if (choice33 == "1" || choice33 == "2")
                        {
                            currentStep = 20; 
                        }
                        else
                        {
                            Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                            Thread.Sleep(1000);
                        }
                        break;

                    
                    case 34:
                        Console.WriteLine("Бумаги - это старые счета и квитанции. Ничего интересного, кроме одного листа с набором цифр: '451'.");
                        Console.WriteLine("1. Запомнить цифры '451'."); 
                        Console.WriteLine("2. Вернуться к осмотру кабинета."); 

                        string choice34 = Console.ReadLine();
                        if (choice34 == "1" || choice34 == "2")
                        {
                            currentStep = 20; 
                        }
                        else
                        {
                            Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                            Thread.Sleep(1000);
                        }
                        break;

                    
                    case 35:
                        Console.WriteLine("Сейф выглядит очень старым и прочным. Кодовый замок покрыт пылью. Вам нужен код. Вы помните числа из книг ('1888') или с бумаг ('451')?");
                        Console.WriteLine("1. Попробовать код '1888'.");
                        Console.WriteLine("2. Попробовать код '451'.");
                        Console.WriteLine("3. Вернуться к осмотру кабинета."); 

                        string choice35 = Console.ReadLine();
                        if (choice35 == "1")
                        {
                            currentStep = 40; 
                        }
                        else if (choice35 == "2")
                        {
                            currentStep = 41; 
                        }
                        else if (choice35 == "3")
                        {
                            currentStep = 20; 
                        }
                        else
                        {
                            Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                            Thread.Sleep(1000);
                        }
                        break;

                    
                    case 36:
                        Console.WriteLine("Вы светите фонариком в угол. Видите большую крысу, которая убегает. Под грудой старых мешков замечаете тускло поблескивающий предмет.");
                        Console.WriteLine("1. Подобрать предмет (шкатулка)."); 
                        Console.WriteLine("2. Испугаться крысы и быстро выйти."); 

                        string choice36 = Console.ReadLine();
                        if (choice36 == "1")
                        {
                            currentStep = 42; 
                        }
                        else if (choice36 == "2")
                        {
                            currentStep = 10; 
                        }
                        else
                        {
                            Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                            Thread.Sleep(1000);
                        }
                        break;

                  
                    case 37:
                        Console.WriteLine("Почерк на обрывке письма почти неразборчив, но удается разобрать пару слов: 'ключ', 'шкатулка', 'кладовка'.");
                        Console.WriteLine("1. Это похоже на подсказку! Нужно вернуться в кухню и кладовку."); 
                        Console.WriteLine("2. Проигнорировать."); 

                        string choice37 = Console.ReadLine();
                        if (choice37 == "1")
                        {
                            currentStep = 10; 
                        }
                        else if (choice37 == "2")
                        {
                            currentStep = 11; 
                        }
                        else
                        {
                            Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                            Thread.Sleep(1000);
                        }
                        break;

                    
                    case 38:
                        Console.WriteLine("Книга очень старая. Это похоже на дневник. Листая его, вы находите запись о некоем ритуале и упоминание 'тени из зеркала'.");
                        Console.WriteLine("1. Это жутко. Нужно выбираться."); 
                        Console.WriteLine("2. Может, в зеркале в холле что-то есть?"); 

                        string choice38 = Console.ReadLine();
                        if (choice38 == "1")
                        {
                            currentStep = 16; 
                        }
                        else if (choice38 == "2")
                        {
                            currentStep = 5; 
                        }
                        else
                        {
                            Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                            Thread.Sleep(1000);
                        }
                        break;

                    
                    case 39:
                        Console.WriteLine("Вы мчитесь по коридору, прочь от жуткого звука. Выбирайтесь из дома быстрее!");
                        Console.WriteLine("1. Бежать к лестнице вниз."); 
                        Console.WriteLine("2. Попробовать выпрыгнуть в ближайшее окно (опасно)."); 

                        string choice39 = Console.ReadLine();
                        if (choice39 == "1")
                        {
                            currentStep = 1; 
                        }
                        else if (choice39 == "2")
                        {
                            currentStep = 906; 
                        }
                        else
                        {
                            Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                            Thread.Sleep(1000);
                        }
                        break;

                    
                    case 40:
                        Console.WriteLine("Вы набираете '1888' на замке сейфа. Слышен щелчок! Сейф открыт.");
                        Console.WriteLine("1. Открыть сейф."); 

                        string choice40 = Console.ReadLine();
                        if (choice40 == "1")
                        {
                            currentStep = 43; 
                        }
                        else 
                        {
                            Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                            Thread.Sleep(1000);
                        }
                        break;

                    
                    case 41:
                        Console.WriteLine("Вы набираете '451' на замке сейфа. Ничего не происходит. Код неверный.");
                        Console.WriteLine("1. Вернуться к осмотру сейфа (попробовать другой код)."); 
                        Console.WriteLine("2. Вернуться в кабинет."); 

                        string choice41 = Console.ReadLine();
                        if (choice41 == "1")
                        {
                            currentStep = 35; 
                        }
                        else if (choice41 == "2")
                        {
                            currentStep = 20; 
                        }
                        else
                        {
                            Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                            Thread.Sleep(1000);
                        }
                        break;

                   
                    case 42:
                        Console.WriteLine("Вы достаете предмет из-под мешков. Это старая металлическая шкатулка, покрытая пылью.");
                        Console.WriteLine("1. Попробовать открыть шкатулку прямо сейчас (заперта).");
                        Console.WriteLine("2. Забрать шкатулку с собой."); 
                        Console.WriteLine("3. Оставить шкатулку.");
                        Console.WriteLine("4. Вернуться на кухню."); 

                        string choice42 = Console.ReadLine();
                        if (choice42 == "1")
                        {
                            Console.WriteLine("Шкатулка заперта. Вам нужен ключ.");
                            Thread.Sleep(1500);
                            currentStep = 42; 
                        }
                        else if (choice42 == "2")
                        {
                            Console.WriteLine("Вы взяли шкатулку. Может, у вас есть ключ, который подойдет?"); 
                            Thread.Sleep(2000);
                            currentStep = 10; 
                        }
                        else if (choice42 == "3" || choice42 == "4")
                        {
                            currentStep = 10; 
                        }
                        else
                        {
                            Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                            Thread.Sleep(1000);
                        }
                        break;

                    
                    case 43:
                        Console.WriteLine("В сейфе лежат важные документы о владении особняком и старый, тяжелый кошелек с золотыми монетами.");
                        Console.WriteLine("1. Взять документы и золото."); 
                        Console.WriteLine("2. Взять только золото."); 
                        Console.WriteLine("3. Оставить все как есть."); 

                        string choice43 = Console.ReadLine();
                        if (choice43 == "1")
                        {
                            currentStep = 903; 
                        }
                        else if (choice43 == "2")
                        {
                            currentStep = 904; 
                        }
                        else if (choice43 == "3")
                        {
                            currentStep = 20; 
                        }
                        else
                        {
                            Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                            Thread.Sleep(1000);
                        }
                        break;

                   

                    case 900: 
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("КОНЕЦ ИСТОРИИ");
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("Вы решили не рисковать и ушли прочь от особняка. Вернувшись домой, вы чувствуете облегчение. Возможно, это было лучшее решение.");
                        isGameOver = true; 
                        break;

                    case 901: 
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("КОНЕЦ ИСТОРИИ");
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("Вы вышли из особняка. Возможно, найдя способ открыть входную дверь или другой выход. Особняк остался позади, его тайны не раскрыты вами. Вы в безопасности.");
                        isGameOver = true;
                        break;

                    case 902: 
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("КОНЕЦ ИСТОРИИ");
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("Вы нашли сокровище! Старинные деньги и ценности позволят вам начать новую жизнь. Вы стали богаты, но история особняка осталась загадкой.");
                        isGameOver = true;
                        break;

                    case 903: 
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("КОНЕЦ ИСТОРИИ");
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("Вы открыли сейф и нашли документы и золото. Теперь у вас есть не только богатство, но и право на владение этим старым особняком. Что вы будете с ним делать?");
                        isGameOver = true;
                        break;

                    case 904: 
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("КОНЕЦ ИСТОРИИ");
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("Вы взяли только золото из сейфа. Богатство ваше, но документы остались в сейфе. Возможно, кто-то еще придет за ними. Вы покинули дом с тяжелым кошельком.");
                        isGameOver = true;
                        break;

                    case 905: 
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("КОНЕЦ ИСТОРИИ");
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("Вы замерли, прислушиваясь. Звук становится ближе, он идет из-за двери. Внезапно дверь распахивается, и что-то хватает вас в темноту. Вы больше никогда не видели дневного света.");
                        isGameOver = true;
                        break;

                    case 906: 
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("КОНЕЦ ИСТОРИИ");
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("Вы выпрыгнули из окна. Падение было жестким, вы сильно ушиблись, но смогли встать и, хромая, уйти прочь от проклятого места. Дом остался позади, но боль напоминает о нем.");
                        isGameOver = true;
                        break;

                    case 907: 
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("КОНЕЦ ИСТОРИИ");
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("Кладка колодца обвалилась, и вы полетели в темноту. Падение было долгим... и последним. Ваше путешествие окончено в глубинах земли.");
                        isGameOver = true;
                        break;

                    case 908: 
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("КОНЕЦ ИСТОРИИ");
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("Вы попытались понять нечто непостижимое, и что-то сломалось в вашем разуме. Вы теряете связь с реальностью, навсегда затерявшись в лабиринтах собственного сознания.");
                        isGameOver = true;
                        break;

                    case 909: 
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("КОНЕЦ ИСТОРИИ");
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("Вы продолжаете всматриваться в треснувшее зеркало. Ваше отражение отделяется от вас, улыбается странной улыбкой и делает шаг вперед. Вы чувствуете, как холодная рука касается вашей. Это конец вашего путешествия в этом мире.");
                        isGameOver = true;
                        break;

                 

                    default: 
                        Console.WriteLine("Произошла ошибка в игре. Неизвестный шаг: " + currentStep);
                        isGameOver = true; 
                        break;
                } 

                
                if (!isGameOver) 
                {
                    Thread.Sleep(500); 
                }

            } 


            
            Console.WriteLine("Нажмите Enter, чтобы узнать, хотите ли сыграть еще.");
            Console.ReadLine(); 
            Console.Write("Хотите сыграть еще раз? (да/нет): ");
            string playAgainInput = Console.ReadLine().Trim().ToLower();

            if (playAgainInput != "да" && playAgainInput != "yes" && playAgainInput != "д" )
            {
                break; 
            }
            

        } 

        Console.WriteLine("Спасибо за игру! До свидания.");
        
    } 
} 
