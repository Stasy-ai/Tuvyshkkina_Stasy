from tkinter import *
from tkinter import messagebox
from tkinter.ttk import Combobox
import sqlite3

# переменная для списка
list = []
# считываем sql скрипт
file = open("Sasha_Botik.db", "r", encoding='utf-8')
build_db = file.read()
file.close()
# создаем соединение с базой данных
connector = sqlite3.connect('Sasha_Botik.db')
# создаем курсора
cursor = connector.cursor()
# выполнение sql скрипта по созданию и заполнению базы данных
cursor.executescript(build_db)
# выбор всех данных из таблицы "services"
sql_services = cursor.execute("Select * from services")
# Добавляем каждую новую услугу в список
for row in sql_services:
    list.append(row[1])
# записываем изменения в базу данных
connector.commit()
# закрываем курсор
cursor.close()
# закрываем подключение
connector.close()

class my_combobox:
    global price, servis
    price = 0
    servis = ""
    def __init__(self, list, font, x, y, width, window):
        self.x = x
        self.y = y
        self.list = list
        self.font = font
        self.width = width
        self.window = window
        self.combobox = Combobox(values=self.list, font=self.font, state="readonly")
        self.combobox.place(x=self.x, y=self.y, width=self.width)
        self.combobox.bind('<<ComboboxSelected>>', lambda event: self.select())
    def select(self):
        global price, servis
        servis = self.combobox.get()
        connector = sqlite3.connect('avto_servis.db')
        cursor = connector.cursor()
        sql_services = cursor.execute(f"Select * from services where name = '{servis}' ")
        for row in sql_services:
            price = row[2]
        connector.commit()
        cursor.close()
        connector.close()

        self.new_label = my_label("Цена: " + str(price) + " руб.", "Arial 15", "lightblue", 450, 250)


class my_button:
    def __init__(self, text, font, x, y, width, window):
        self.x = x
        self.y = y
        self.text = text
        self.font = font
        self.width = width
        self.window = window
        self.button = Button(text=self.text, font=self.font, command=self.click)
        self.button.place(x=self.x, y=self.y, width=self.width)

    def click(self):
        self.value_marka = self.window.entry_marka.value.get()  # марка машины
        self.value_model = self.window.entry_model.value.get()  # модель машины
        self.value_color = self.window.entry_color.value.get()  # цвет машины
        self.value_year_build = self.window.entry_year_build.value.get()  # год производства
        self.value_number = self.window.entry_number.value.get()  # номер машины
        self.value_surname = self.window.entry_surname.value.get()  # фамилия
        self.value_name = self.window.entry_name.value.get()  # имя
        self.value_phone_number = self.window.entry_phone_number.value.get()  #телефон
        if self.check_empty():
            messagebox.showinfo("Сообщение", "Данные успешно загружены!")
            self.print_file()
        else:
            messagebox.showerror("Ошибка", "Не все поля заполнены!")


    def print_file(self):
        global servis, price
        file = open('new_otchet.txt', 'w', encoding="utf8")
        file.write("Марка машины: " + self.value_marka + "\n")
        file.write("Модель машины: " + self.value_model + "\n")
        file.write("Цвет машины: " + self.value_color + "\n")
        file.write("Год производства: " + self.value_year_build + "\n")
        file.write("Номер машины: " + self.value_number + "\n")
        file.write("Услуга: " + servis + "\n")
        file.write("Стоимость: " + str(price) + "\n")
        file.close()


    def check_empty(self):
        global servis, price
        if not self.value_marka or \
                not self.value_model \
                or not self.value_color \
                or not self.value_year_build \
                or not self.value_number \
                or not servis \
                or not self.value_surname \
                or not self.value_name \
                or not self.value_phone_number:
                return False
        else:
            return True


class my_entry:
    def __init__(self, font, x, y, width):
        self.x = x
        self.y = y
        self.font = font
        self.width = width
        self.value = StringVar()

        self.entry = Entry(textvariable=self.value, font=self.font)
        self.entry.place(x=self.x, y=self.y, width=self.width)


class my_label:
    def __init__(self, text, font, color, x, y):
        self.text = text
        self.x = x
        self.y = y
        self.font = font
        self.color = color

        self.label = Label(text=self.text, font=self.font, bg=color)
        self.label.place(x=self.x, y=self.y)


class my_window:
    def __init__(self):
        self.window = Tk()
        self.window.geometry("700x700")

        self.window.title("мое окно")

        self.window.configure(bg="blue")
        self.window.resizable(width=False, height=False)
        self.__my_canva()
        self.__new_label()
        self.__new_entry()
        self.__new_button()
        self.__new_combobox()

        self.window.mainloop()

    def __my_canva(self):
        self.canva = Canvas(width=670, height=670, bg="lightblue")
        self.canva.pack()

    def __new_label(self):
        self.label_title = my_label("АВТОСЕРВИС CAT & Со", "Arial 20", "lightblue",180, 50)
        self.label_marka = my_label("Марка автомобиля:", "Arial 15", "lightblue",50, 150)
        self.label_model = my_label("Модель автомобиля:", "Arial 15", "lightblue", 50, 200)
        self.label_color = my_label("Цвет:", "Arial 15", "lightblue", 50, 250)
        self.year_build = my_label("Год производства:", "Arial 15", "lightblue",50, 300)
        self.car_number = my_label("Номер автомобиля:", "Arial 15", "lightblue", 50, 350)

        self.car_servise = my_label("Наименование услуги:", "Arial 15", "lightblue", 450, 150)

        self.surname = my_label("Фамилия:", "Arial 15", "lightblue", 50, 450)
        self.name = my_label("Имя:", "Arial 15", "lightblue", 50, 500)
        self.phone_number = my_label("Номер телефона:", "Arial 15", "lightblue", 50, 550)


    def __new_entry(self):
        self.entry_marka = my_entry("Arial 15", 270, 150, 150)
        self.entry_model = my_entry("Arial 15", 270, 200, 150)
        self.entry_color = my_entry("Arial 15", 270, 250, 150)
        self.entry_year_build = my_entry("Arial 15", 270, 300, 150)
        self.entry_number = my_entry("Arial 15", 270, 350, 150)

        self.entry_surname = my_entry("Arial 15", 270, 450, 150)
        self.entry_name = my_entry("Arial 15", 270, 500, 150)
        self.entry_phone_number = my_entry("Arial 15", 270, 550, 150)


    def __new_button(self):
        self.write_btn = my_button("Записать", "Arial 15", 500, 600, 100, self)

    def __new_combobox(self):
        global list
        self.servis_combobox = my_combobox(list, "Arial 13", 450, 200, 200, self)


new_window = my_window()
