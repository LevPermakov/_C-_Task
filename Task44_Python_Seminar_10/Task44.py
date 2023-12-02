# Задача 44: В ячейке ниже представлен код генерирующий DataFrame, которая состоит всего
# из 1 столбца. Ваша задача перевести его в one hot вид. Сможете ли вы это сделать без
# get_dummies?
# import random
# lst = ['robot'] * 10
# lst += ['human'] * 10
# random.shuffle(lst)
# data = pd.DataFrame({'whoAmI':lst})
# data.head()

# # Для кодировки категориальных данных можно использовать метод pandas get_dummies
# pd.get_dummies(df['Type 1'])



import pandas as pd
import random

lst = ['robot'] * 10
# print(lst)
lst += ['human'] * 10
# print(lst)
random.shuffle(lst)
# print(lst)
data = pd.DataFrame({'whoAmI': lst})
# print(data)
data.head()    # по умолчанию head() отбражает первые 5 сторок
# print(data.head())

unique_values = data['whoAmI'].unique()  # Получаем уникальные значения из стольбца 'whoAmI': ['robot' 'human']
# print(unique_values)

one_hot_data = pd.DataFrame()            # Создаем пустой DataFrame
#    print(one_hot_data)
# Empty DataFrame
# Columns:  []
# Index:    []

# Для каждого уникального значения создаем новый столбец и заполняем его значениями 0 или 1
for value in unique_values:
    one_hot_data[value] = (data['whoAmI'] == value).astype(int)  # столбец данных преобразовать в другой тип (int)
# print(one_hot_data)    
    
one_hot_data.head()
# print(one_hot_data.head())    
#        human  robot
#   0      1      0
#   1      1      0
#   2      1      0
#   3      1      0
#   4      0      1



