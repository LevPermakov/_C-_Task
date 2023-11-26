# Здравствуйте, Тимур!
# Мне не удалось участвовать в Семинарах в реальном масштабе времени.
# По времени для меня оказалось поздно (домашние проблемы), 
# хотя в момент определения графика обучения, куратор обозначил более раннее начало Семинаров.
# Каждый Семинар отработал по Записи с параллельным написанием кода в VSC.
# Все Домашние Задания выполнил в VSC.
# Аналогично делаю ДЗ по Телефонной Книге (получается, что индивидуально - без группы)

#     Реализую Задание в три этапа:
#     1. "Ручное" формирование записей тел.кн. (как сделала 3-я группа Семинара 8)
#     2. Сохранение на диск в формате json
#     3. Работа с записями тел.кн. через sqlite3 и выделенные функции (методы)
    
# contacts = {}
contacts = {'Lev': {'phones': ['+79222428181', ' +89222428181'], 'email': ['perl_55@mail.ru'], 'birthday': ''}, 
 'Lev_': {'phones': ['+89222428181'], 'email': ['perl_55@mail.ru'], 'birthday': '22/12/1955'}}
    
# operations_dict = {
#                     'add': add_contact(),
#                     'del': del_contact(),
#                     'find': find_contact(),
#                     'all': show_all(),
#                     'edit': edit_contact(),
#                     'close': close_app(),
#                     'save': save_contact()
#                     }

# def add_contact():
# def save():

        # try:
        #     operations_dict[command]
            
        # except:
        #     print(f'Команда: {command} - не найдена')

def main_cycle():
    while True:
        print('''Выберите действие:
              add - добавить контакт
              del - удалить контакт
              find - поиск контакта
              show - показать все контакты
              edit - изменить контакт
              close - закрыть приложение
              save - сохранить контакт
              '''
            )
        command = input("Введите команду: ")  # Особенность: 1) id - Имя
        if command == "add":                  
            contact_name = input("Введите имя: ")
            phones = input("Введите номера телефонов через запятую: ").split(",")
            email =  input("Введите электронные адреса (email) через запятую: ").split(",")
            # birthday = input("Введите день рождения: ")
            contact = {
                'phones': phones,
                'email': email,
                'birthday': input("Введите день рождения: ")
            }
            contacts[contact_name] = contact  # 1) При Дубликате - замена(!) 2) Вводит "Пустой" контакт.
            # {'Lev': {'phones': [''], 'email': [''], 'birthday': ''}, 
            #  'Lev_': {'phones': ['+89222428181'], 'email': ['perl_55@mail.ru'], 'birthday': '22/12/1955'}, 
            #  '': {'phones': [''], 'email': [''], 'birthday': ''}}
            
            print("Контакт успешно добавлен")
            print(contacts)
            print()
        elif command == "show":
            print(contacts)
            print()
        elif command == "find":
            contact_name = input("Введите имя: ")
            print(contacts[contact_name])
        elif command == "del":                         # выброс с ошибкой при {} словаре
            contact_name = input("Введите имя: ")
            del contacts[contact_name]
            print("Запись успешно удалена")
            print()
        elif command == "save":
            # save()
            print("Все контакты успешно сохранены")
            print()
        elif command == "exit":
            break
        else:
            print("Некорректная команда.")
            print()

main_cycle()
        
        

            

    