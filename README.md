# (ru) Resolution Changer

Программа для автоматического изменения разрешения экрана при запуске указанного процесса. Подойдет тем, кто пользуется растянутым разрешением в приложениях/играх в "полноэкранном в окне" режиме.

## Функциональность

- Автоматическое изменение разрешения экрана при запуске целевого процесса
- Возврат к исходному разрешению при закрытии процесса
- Настройка желаемого разрешения через интерфейс
- Отображение статуса операций
- Поддержка английского языка (кал конечно в такой мелкой программке, но хоть что-то)

## Требования

- ОС Windows 7 или новее
- .NET Framework 4.7.2 или .NET 6.0+
- Доступ к изменению разрешения экрана

## Установка

1. Скачайте последнюю версию приложения из раздела Releases
2. Распакуйте архив
3. Запустите `ResolutionChanger.exe` или `ResChangerConsole.exe` (обычная консолька, зато весит намного меньше)

## Использование

1. Введите имя процесса (без .exe) в соответствующее поле (имя процесса можно посмотреть в диспетчере задач)
2. Укажите желаемое разрешение (ширину и высоту)
3. Нажмите "Начать мониторинг"
4. Приложение будет автоматически изменять разрешение при запуске/закрытии процесса

## Интерфейс приложения

![image](https://github.com/user-attachments/assets/1e936af6-cc51-4412-9cec-68459ddf7e94)

![image](https://github.com/user-attachments/assets/6383e586-db73-49c3-a858-5af96887fab5)


## Сборка из исходного кода

1. Клонируйте репозиторий: git clone https://github.com/pohib/Resolution-Changer.git
2. Откройте решение ResChangerConsole.csproj в Visual Studio
3. Соберите решение "Program.cs" (Build → Build Solution)
4. Запустите приложение (F5)

## Возможные проблемы

- Приложение требует прав администратора для изменения разрешения
- Некоторые процессы могут иметь несколько экземпляров
- В редких случаях может потребоваться перезагрузка для применения изменений

## Примечание
Чтобы изменить разрешение на кастомное, оно должно быть добавлено в nvidia/amd.

 





# (en) Resolution Changer

A program for automatically changing the screen resolution when the specified process is started. Suitable for those who use stretched resolution in applications / games in "full-screen in the window" mode.

## Functionality

- Automatic screen resolution change when starting the target process
- Return to the original resolution when the process is closed
- Setting the desired resolution through the interface
- Operation status display
- English language support (cal, of course, in such a small program, but at least something)

## Requirements

- Windows 7 or later
- .NET Framework 4.7.2 or .NET 6.0+
- Access to change the screen resolution

## Installation

1. Download the latest version of the app from the Releases section
2. Unpack the archive
3. Run `ResolutionChanger.exe ` or `ResChangerConsole.exe ` (default console app, but it weighs much less)

## Usage

1. Enter the process name (without .exe) in the appropriate field (you can view the process name in the Task Manager)
2. Specify the desired resolution (width and height)
3. Click "Start monitoring"
4. The application will automatically change the permission when starting/closing the process.

## Application Interface

![image](https://github.com/user-attachments/assets/3c0f7a73-7d90-45ae-a99b-a6e0451abe37)

![image](https://github.com/user-attachments/assets/d56b0783-bd65-4078-bdbf-cc07559cb1ae)



## Build from source code

1. Clone the repository: git clone https://github.com/pohib/Resolution-Changer.git
2. Open the ResChangerConsole.csproj solution in Visual Studio
3. Build the "Program.cs" solution (Build → Build Solution)
4. Launch the application (F5)

## Possible problems

- The application requires administrator rights to change the permission
- Some processes may have multiple instances
- In rare cases, you may need to reboot to apply the changes.

## Note
To change the resolution to a custom one, it must be added to nvidia/amd.
