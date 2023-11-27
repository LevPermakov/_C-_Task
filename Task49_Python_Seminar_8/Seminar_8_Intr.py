
import sqlite3 as sl
from easygui import *    #самая простейшая библиотека - easygui
# если не входит в состав Pythoy, надо установить или сделать через install
# возможно, необходимо выйти из Виртуального Окружения VSC (лучше работать в Глообальном Окружении)
# См. запись Семинара - time: 34:00
## PS D:\_Python_Task> pip install easygui
# import easygui as eu

#  Этап 1. Установка соединения с БД
conn = sl.connect("test_evening.db")

#  Этап 2. Создание курсора 
# (позвояляет взаимодействовать с БД 
# с помощью SQL-запросов)
#  conn - название подключения
cur = conn.cursor()

#  3) Запрос на создание Таблицы
#  execute - выполнить
cur.execute("""
            CREATE TABLE IF NOT EXISTS users
            (
            id INTEGER PRIMARY KEY,
            name TEXT,
            surname TEXT
            );
            """)

#  4) Добавляем инф-цию (значение в скобках)
#     Важно! Передоваемые значения должны соответствовать объявленым  типам и в таком же порядке
#     В конце запроса - ;
cur.execute("INSERT INTO users VALUES (1, 'Ваня','Петров');")
cur.execute("INSERT INTO users VALUES (2, 'Сергей','Сергеев');")

#  5) запрос
cur.execute("SELECT * FROM users;")    #  - вывести всю информацию

#  6) вывести информацию - будет список картежей
print(cur.fetchall())   # [(1, 'Ваня', 'Петров'), (2, 'Сергей', 'Сергеев')]

#  _7_) При повторной транзакции некоторые команды (создать уже созданное) будут проигнориваны.
#       Ошибок не будет. -->  [(1, 'Ваня', 'Петров'), (2, 'Сергей', 'Сергеев')]
# !!! все-таки, начал ругаться по повтору ввода инф. в стр. 31 и 32

#  8) Использовние интерфейса для конечного пользователя
#     Как вариант - goi - графический интерфейс
#  сделаем графический интерфейс - см. выше
#  from easygui import *


#  Создаем функционал:

def select_all():
    cur.execute("SELECT * FROM users;")
    return cur.fetchall()

def add_values():
    cur.execute("INSERT INTO users VALUES (1,'Ваня','Петров');")
    cur.execute("INSERT INTO users VALUES (2,'Сергей','Сергеев');")

def select_ivan():
    cur.execute("SELECT * FROM users WHERE name = 'Ваня';")
    return cur.fetchall()

#  8.1.  Запрос в goi
choice = choicebox("Выберите запрос", "Главная форма", 
                   ['Все записи', "Только Ваня"])
# add_values()

#  8.2.  Обработка запроса (для обработки - def должны return)
if choice == "Все записи":
    msg = str(select_all())
    # print(msg)
    msgbox(msg, "Результат запроса")
# if choice == "Только Ваня":
#     msg = str(select_ivan())
#     msgbox(msg, "Результат запроса")

conn.commit()
conn.close()

#  9) Шаблон словаря Справочника (словарь со словарями)
phonebook = {"дядя Ваня": {'phones': [1212121,5555555],
                           'email': '777@mail.com', 'birthday': '10.10.1990'},
             "дядя Вася": {'phones': [888888]}                         
            }

# print(phonebook['дядя Ваня'])  # Вся инф. по дяде Ване
# # {'phones': [1212121, 5555555], 'email': '777@mail.com', 'birthday': '10.10.1990'}
# print(phonebook['дядя Ваня'] ['phones'])   # только телефоны
# # [1212121, 5555555]
# print(phonebook['дядя Ваня'] ['phones'] [0])   # только первый телефон: #в списке - [0]
# # 1212121
