USE [master]
GO
/****** Object:  Database [Tests]    Script Date: 21.04.2023 11:24:41 ******/
CREATE DATABASE [Tests]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Tests', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Tests.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Tests_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Tests_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Tests] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Tests].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Tests] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Tests] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Tests] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Tests] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Tests] SET ARITHABORT OFF 
GO
ALTER DATABASE [Tests] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Tests] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Tests] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Tests] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Tests] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Tests] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Tests] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Tests] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Tests] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Tests] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Tests] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Tests] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Tests] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Tests] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Tests] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Tests] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Tests] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Tests] SET RECOVERY FULL 
GO
ALTER DATABASE [Tests] SET  MULTI_USER 
GO
ALTER DATABASE [Tests] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Tests] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Tests] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Tests] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Tests] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Tests] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Tests', N'ON'
GO
ALTER DATABASE [Tests] SET QUERY_STORE = ON
GO
ALTER DATABASE [Tests] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Tests]
GO
/****** Object:  Table [dbo].[Admins]    Script Date: 21.04.2023 11:24:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admins](
	[Id_Admin] [int] IDENTITY(1,1) NOT NULL,
	[Login_Admin] [nvarchar](20) NULL,
	[Password_Admin] [nvarchar](20) NULL,
 CONSTRAINT [PK_Admins] PRIMARY KEY CLUSTERED 
(
	[Id_Admin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Questins]    Script Date: 21.04.2023 11:24:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Questins](
	[Id_Question] [int] IDENTITY(1,1) NOT NULL,
	[Test_Id] [int] NULL,
	[Text_Question] [nvarchar](1000) NULL,
	[First_Answer] [nvarchar](500) NULL,
	[Second_Answer] [nvarchar](500) NULL,
	[Third_Answer] [nvarchar](500) NULL,
	[Fourth_Answer] [nvarchar](500) NULL,
	[Correct_Answer] [nvarchar](500) NULL,
 CONSTRAINT [PK_Questins] PRIMARY KEY CLUSTERED 
(
	[Id_Question] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Result]    Script Date: 21.04.2023 11:24:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Result](
	[Id_Result] [int] IDENTITY(1,1) NOT NULL,
	[Test_Id] [int] NULL,
	[Uzer_Id] [int] NULL,
	[Number_Correct_Answers] [nvarchar](13) NULL,
	[Percentage_Correct_Answers] [nvarchar](3) NULL,
	[Test_Start_Time] [datetime] NULL,
	[Time_Spent] [time](7) NULL,
 CONSTRAINT [PK_Result] PRIMARY KEY CLUSTERED 
(
	[Id_Result] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tester]    Script Date: 21.04.2023 11:24:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tester](
	[Id_Tester] [int] IDENTITY(1,1) NOT NULL,
	[Full_Name_Tester] [nvarchar](150) NULL,
	[Login_Tester] [nvarchar](20) NULL,
	[Password_Tester] [nvarchar](20) NULL,
 CONSTRAINT [PK_Tester] PRIMARY KEY CLUSTERED 
(
	[Id_Tester] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tests]    Script Date: 21.04.2023 11:24:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tests](
	[Id_Test] [int] IDENTITY(1,1) NOT NULL,
	[Tester_Id] [int] NULL,
	[Name_Test] [nvarchar](300) NULL,
	[Time_Complete] [int] NULL,
 CONSTRAINT [PK_Tests] PRIMARY KEY CLUSTERED 
(
	[Id_Test] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Uzers]    Script Date: 21.04.2023 11:24:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Uzers](
	[Id_Uzer] [int] IDENTITY(1,1) NOT NULL,
	[Full_Name_Uzer] [nvarchar](150) NULL,
	[Login_Uzer] [nvarchar](20) NULL,
	[Password_Uzer] [nvarchar](20) NULL,
 CONSTRAINT [PK_Uzers] PRIMARY KEY CLUSTERED 
(
	[Id_Uzer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Admins] ON 

INSERT [dbo].[Admins] ([Id_Admin], [Login_Admin], [Password_Admin]) VALUES (1, N'Admin', N'Admin')
SET IDENTITY_INSERT [dbo].[Admins] OFF
GO
SET IDENTITY_INSERT [dbo].[Questins] ON 

INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (1, 1, N'Организационная стратегия интеграции производства и операций, управления трудовыми ресурсами, финансового менеджмента и управления активами, ориентированная на непрерывную балансировку и оптимизацию ресурсов предприятия посредством специализированного интегрированного пакета прикладного программного обеспечения, обеспечивающего общую модель данных и процессов для всех сфер деятельности – это…', N'ЕАМ (Enterprise asset management)', N'ERP (Enterprise Resource Planning)', N'PLM (Product Lifecycle Management)', N'APS (American Physical Society)', N'ERP (Enterprise Resource Planning)')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (2, 1, N'НИОКР подразделяются на:', N'товарные НИОКР, Капитальные НИОКР', N'краткосрочные, среднесрочные', N'стратегически важные, потенциально интересные', N'объективные, субъективные', N'товарные НИОКР, Капитальные НИОКР')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (3, 1, N'Инновации бывают:', N'продуктовые, процессные,', N'улучшающие, радикальные', N'объективные, субъективные', N'патентные, лицензионные', N'продуктовые, процессные,')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (4, 1, N'Отличие между инновацией и новшеством – это …', N'приобретение существенной конкурентоспособности и реализация на рынке', N'больший масштаб использования инновации, чем новшества', N'повышение рейтинга организации за счет использования новшества', N'повышение стимула для сотрудников: при предложении инновации сотрудник получает процент от прибыли от реализации данного новшества', N'приобретение существенной конкурентоспособности и реализация на рынке')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (5, 1, N'Технологии проектирования – это совокупность …', N'пошаговых процедур, определяющих последовательность технологических операций проектирования;', N'критериев и правил, на основании которых определяется техническое задание', N'графических и текстовых средств, определяющих последовательность разработки плана реализации', N'таблиц, используемых для оценки проектируемой системы в баллах.', N'пошаговых процедур, определяющих последовательность технологических операций проектирования;')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (6, 2, N'Единицей измерения информации является:', N'бод', N'бит', N'ампер', N'герц', N'бит')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (7, 2, N'Какая система счисления используется при представлении числа в памяти компьютера:', N'десятичная', N'двоичная', N'троичная', N'шестидесятеричная', N'двоичная')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (8, 2, N'Обработку данных производит:', N'процессор', N'жесткий диск', N'сервер', N'сканер', N'процессор')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (9, 2, N'При стандартных установках Windows одинарным щелчком правой кнопкой мыши можно:', N'вызвать контекстное меню', N'открыть объект', N'выделить слово в текстовом документе', N'установить текущее положение указателя ввода информации', N'вызвать контекстное меню')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (10, 2, N'Содержимое контекстного меню зависит от', N'состояния здоровья пользователя', N'места расположения указателя мыши в момент щелчка правой кнопки', N'числа открытых на рабочем столе окон', N'размера выделенной области', N'места расположения указателя мыши в момент щелчка правой кнопки')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (11, 3, N'Информатика – это (исключить лишнее понятие):', N'это область человеческой деятельности, связанная с процессами преобразования информации с помощью компьютеров и их взаимодействием со средой применения.', N'это наука, изучающая структуру и наиболее общие свойства информации, ее поиск, хранение, передачу и обработку с применением ЭВМ.', N'комплексная научная и инженерная дисциплина, изучающая все аспекты разработки, проектирования, создания, оценки, функционирования компьютерных систем переработки информации, их применения и воздействия на различные области человеческой деятельности.', N'технологические операции с научно-технической информацией, документалистика, библиотечное дело, хранение и обработка материалов научных исследований.', N'технологические операции с научно-технической информацией, документалистика, библиотечное дело, хранение и обработка материалов научных исследований.')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (12, 3, N'Главная функция информатики:', N'разработка методов и средств преобразования информации и их использование в организации технологического процесса переработки информации.', N'исследование информационных процессов любой природы.', N'разработка информационной техники и создание новейшей технологии переработки информации на базе полученных результатов исследования информационных процессов.', N'решение научных и инженерных проблем создания, внедрения и обеспечения эффективного использования компьютерной техники и технологии во всех сферах общественной жизни.', N'разработка методов и средств преобразования информации и их использование в организации технологического процесса переработки информации.')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (13, 3, N'Образовательные задачи информатики (исключите лишнее):', N'формирование у пользователей компьютера навыков грамотной постановки задач, возникающих в практической деятельности, для их решения с помощью компьютера.', N'формирование у пользователей компьютера навыков использования основных типов прикладных программ общего назначения для решения с их помощью практических задач и понимания основных принципов, лежащих в основе этих систем.', N'формирование у пользователей компьютера навыков печати десятипалым методом.', N'формирование у пользователей компьютера умения грамотно интерпретировать результаты решения практических задач с помощью компьютеров и применять эти результаты в практической деятельности.', N'формирование у пользователей компьютера навыков печати десятипалым методом.')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (14, 3, N'Основная идея семантической информации заключается в том, что:', N'семантическую информацию, воспринимаемую данной системой, можно оценивать по степени изменения содержащейся в системе собственной семантической информации за счет накопления внешней информации.', N'семантическую информацию, воспринимаемую данной системой, можно оценивать по внешним данным.', N'семантическую информацию, воспринимаемую данной системой, можно оценивать по способности вмещать строго-определенный объем данных.', N'семантическую информацию, воспринимаемую данной системой, можно оценивать по гибкости изменения объема информации.', N'семантическую информацию, воспринимаемую данной системой, можно оценивать по степени изменения содержащейся в системе собственной семантической информации за счет накопления внешней информации.')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (15, 3, N'Что такое кибернетика?', N'наука об искусственном интеллекте.', N'наука об общих закономерностях процессов управления и передачи информации в машинах, живых организмах и обществе.', N'наука об ЭВМ.', N'наука о формах и законах человеческого мышления.', N'наука об общих закономерностях процессов управления и передачи информации в машинах, живых организмах и обществе.')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (16, 4, N'Информационные технологии – это:', N'сведения о ком-то или о чём-то, передаваемые в форме знаков или сигналов.', N'технологии накопления, обработки и передачи информации с использованием определённых (технических) средств.', N'процессы передачи, накопления и переработки информации в общении людей, в живых организмах, технических устройствах и жизни общества.', N'система для работы с программами, файлами и оглавлениями данных на компьютере.', N'технологии накопления, обработки и передачи информации с использованием определённых (технических) средств.')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (17, 4, N'Программа – это:', N'игры, предназначенные для использования на компьютере.', N'набор инструкций на машинном языке, который хранится в виде файла на магнитном диске и по команде пользователя загружается в компьютер для выполнения.', N'набор инструкций, предназначенный для запуска компьютера.', N'набор инструкций, предназначенный для работы компьютера.', N'набор инструкций на машинном языке, который хранится в виде файла на магнитном диске и по команде пользователя загружается в компьютер для выполнения.')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (18, 4, N'Прикладные программы - это:', N'программы, предназначенные для решения конкретных задач.', N'программы, управляющие работой аппаратных средств и обеспечивающие услугами нас и наши прикладные комплексы.', N'игры, драйверы и т.д.', N'программы, которые хранятся на различного типа съемных носителях.', N'программы, предназначенные для решения конкретных задач.')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (19, 4, N'Системные программы:', N'управляют работой аппаратных устройств и обеспечивают услугами нас и наши прикладные комплексы.', N'управляют работой компьютера с помощью электрических импульсов.', N'игры, драйверы и т.д.', N'программы, которые хранятся на жёстком диске.', N'управляют работой аппаратных устройств и обеспечивают услугами нас и наши прикладные комплексы.')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (20, 4, N'Кто является основоположником отечественной вычислительной техники?', N'С.А. Лебедев', N'М.В. Ломоносов', N'П.Л. Чебышев', N'Н.И. Лобачевский', N'С.А. Лебедев')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (21, 4, N'Первоначальный смысл английского слова "компьютер"?', N'вид телескопа', N'электронный аппарат', N'электронно-лучевая трубка', N'человек, производящий расчёты', N'вид телескопа')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (22, 4, N'В каком году появилась первая ЭВМ?', N'1823', N'1946', N'1951', N'1949', N'1946')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (23, 5, N'На каком этапе жизненного цикла создания ИС проводится анализ предметной области?', N'проектирование', N'ввод в эксплуатацию', N'предпроектное обследование', N'сопровождение', N'предпроектное обследование')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (24, 5, N'«Такое свойство системы, как (…) системы означает, что в зависимости от точки зрения на нее она может быть разделена на подсистемы, каждая из которых выполняет свою функцию».', N'сложность', N'делимость', N'структурированность', N'целостность', N'делимость')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (25, 5, N'Обоснование целей проекта и обоснование экономической эффективности в целом проводится на этапе:', N'предынвестиционный анализ', N'планирование проекта', N'выполнения проекта', N'завершение проекта', N'предынвестиционный анализ')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (26, 5, N'Отчетность и документирование результатов производится на этапе :', N'выполнение проекта', N'завершение проекта', N'предынвестиционный анализ проекта', N'планирование проекта', N'завершение проекта')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (27, 5, N'Такие проектные функции как : контроль за ходом проекта, оперативное управление проектом, перепланирование проекта осуществляется на этапе …', N'предынвестиционный анализ', N'планирование проекта', N'выполнения проекта', N'завершение проекта', N'выполнения проекта')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (28, 5, N'В каком виде можно коммерциализовать результаты НИОКР?', N'оказываемая услуга', N'продажа лицензий', N'продажа товаров', N'во всех вышеперечисленных', N'во всех вышеперечисленных')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (29, 5, N'Инновационный проект может быть направлен на :', N'снижение себестоимости продукта/услуги', N'создание новых потребностей', N'открытие и захват новых рынков, в том числе и внешних', N'во всех вышеперечисленных', N'во всех вышеперечисленных')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (30, 5, N'Набор функций СУП включает в себя:', N'работу с расписанием', N'работу с календарями', N'управление ресурсами', N'объективное проектирование', N'работу с расписанием')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (31, 5, N'ТЭО-ИНВЕСТ относятся к типу:', N'системы финансового, календарного планирования и контроля', N'профессиональные системы управления проектами', N'субъективные системы управления проектами', N'квантовые системы управления проектами', N'системы финансового, календарного планирования и контроля')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (32, 5, N'Внедрение ИС управления проектами НЕ включает :', N'рекламу внедрения ИС управления проектами', N'подготовку персонала;', N'комплектацию информационной системы программным обеспечением и техническими средствами;', N'проведение опытной эксплуатации информационной системы и ее доработку;', N'рекламу внедрения ИС управления проектами')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (33, 6, N'Какое из устройств наиболее отрицательно влияет на здоровье человека', N'устройство чтения компакт-диска', N'аудио-колонки', N'дисплей', N'жесткий диск', N'дисплей')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (34, 6, N'С точки зрения Пользователя компьютера файл (file) это –', N'единица хранения информации на устройстве', N'ящик для хранения инструкций по использованию инструкций', N'носитель информации', N'место хранения для нескольких документов', N'единица хранения информации на устройстве')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (35, 6, N'Понятие «Папка» означает:', N'элемент файловой системы', N'несколько файлов, хранящихся в одном месте', N'ящик для хранения инструкций', N'документ, хранящийся на компакт-диске', N'элемент файловой системы')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (36, 6, N'Папки могут содержать', N'только файлы', N'только папки', N'файлы и папки', N'файлы и не более трех папок', N'файлы и папки')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (37, 6, N'Для перевода дополнительного блока клавиатуры в цифровой режим нужно нажать клавишу или сочетание клавиш:', N'NumLock', N'CapsLock', N'этой частью клавиатуры лучше вообще не баловаться', N'Tab', N'NumLock')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (38, 6, N'При отключении цифрового режима (NumLock)', N'компьютер не реагирует на нажатие клавиш дополнительной клавиатуры', N'дополнительная цифровая клавиатура работает как клавиши управления движением курсора', N'нажатие на любую клавишу дополнительной цифровой клавиатуры блокирует работу компьютера', N'дополнительная цифровая клавиатура работает как функциональная клавиатура', N'дополнительная цифровая клавиатура работает как клавиши управления движением курсора')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (39, 6, N'Рабочий стол это:', N'место, куда установлен дисплей', N'подставка под клавиатуру', N'изображение на экране дисплея с размещенными на нем элементами управления', N'папка, хранящая документы пользователя.', N'изображение на экране дисплея с размещенными на нем элементами управления')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (40, 7, N'Статистика как наука изучает:', N'единичные явления;', N'массовые явления;', N'периодические события.', N'Все перечисленные варианты', N'массовые явления;')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (41, 7, N'Термин статистика происходит от слова:', N'статика;', N'статный;', N'статус.', N'Все перечисленные варианты', N'статус.')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (42, 7, N'Статистика зародилась и оформилась как самостоятельная учебная дисциплина:', N'до новой эры, в Китае и Древнем Риме;', N'в 17-18 веках, в Европе;', N'в 20 веке, в России.', N'Все перечисленные варианты', N'в 17-18 веках, в Европе;')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (43, 7, N'Статистика изучает явления и процессы посредством изучения:', N'определенной информации;', N'статистических показателей;', N'признаков различных явлений.', N'Все перечисленные варианты', N'статистических показателей;')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (44, 7, N'Статистическая совокупность – это:', N'множество изучаемых разнородных объектов;', N'множество единиц изучаемого явления;', N'группа зафиксированных случайных событий.', N'Все перечисленные варианты', N'множество единиц изучаемого явления;')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (45, 8, N'Законодательно закреплено … видов оперативно-розыскных мероприятий.', N'10;', N'12;', N'14;', N'16.', N'14;')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (46, 8, N'Перечень видов специальных технических средств, предназначенных для негласного получения информации в процессе осуществления оперативно-розыскной деятельности, устанавливается …', N'президентом Российской Федерации;', N'правительством Российской Федерации;', N'конституционным судом Российской Федерации;', N'государственной Думой.', N'правительством Российской Федерации;')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (47, 8, N'К оперативно-розыскным мероприятиям, не ограничивающим конституционные права граждан не относят:', N'опрос;', N'наведение справок;', N'сбор образцов для сравнительного исследования;', N'наблюдение.', N'наблюдение.')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (48, 9, N'Денежные притоки фирмы возникают в связи с тем, что она', N'формирует запас оборотных средств', N'нанимает наемных рабочих', N'приобретает основные фонды', N'привлекает кредиты', N'привлекает кредиты')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (49, 9, N'Сопоставление величины исходной инвестиции с общей суммой дисконтированных денежных поступлений, генерируемых ею в течение прогнозируемого срока позволяет определить показатель', N'DPP', N'IRR', N'NPV', N'PI', N'NPV')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (50, 9, N'Инвестиционные портфели принято классифицировать по степени риска и', N'в зависимости от источника доходов по ценным бумагам портфеля', N'длительности холдингового периода', N'по реакции на темпы инфляции', N'по количеству входящих в них ценных бумаг', N'в зависимости от источника доходов по ценным бумагам портфеля')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (51, 9, N'Если инвестор сформировал «портфель роста», то он рассчитывает на рост', N'ВВП', N'курсовой стоимости ценных бумаг портфеля', N'количества ценных бумаг в портфеле', N'темпов инфляции', N'курсовой стоимости ценных бумаг портфеля')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (52, 9, N'Верно ли утверждение, что оптимальный портфель обязательно должен быть эффективным?', N'да', N'нет, в определенных условиях инвестор может в качестве оптимального выбирать и неэффективный портфель', N'это зависит от отношения конкретного инвестора к риску', N'нет, при высоких уровнях корреляции это условие может не выполняться ', N'да')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (53, 9, N'Для определения IRR проекта используется метод', N'цепных подстановок', N'наименьших квадратов', N'последовательных итераций', N'критического пути', N'последовательных итераций')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (54, 10, N'Статистический показатель дает оценку свойства изучаемого явления:', N'количественную;', N'качественную;', N'количественную и качественную.', N'Все перечисленные варианты', N'количественную;')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (55, 10, N'Основные стадии экономико-статистического исследования включают: а) сбор первичных данных, б) статистическая сводка и группировка данных, в) контроль и управление объектами статистического изучения, г) анализ статистических данных', N'а, б, в', N'а, в, г', N'а ,б, г', N'б, в, г', N'а ,б, г')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (56, 10, N'Закон больших чисел утверждает, что:', N'чем больше единиц охвачено статистическим наблюдением,тем лучше проявляется общая закономерность;', N'чем больше единиц охвачено статистическим наблюдением, тем хуже проявляется общая закономерность;', N'чем меньше единиц охвачено статистическим наблюдением, тем лучше проявляется общая закономерность.', N'Все перечисленные варианты', N'чем больше единиц охвачено статистическим наблюдением,тем лучше проявляется общая закономерность;')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (57, 11, N'Способ получения информации о признаках преступной деятельности путем перемещения под контролем правоохранительных органов товаров и предметов в целях выявления пресечения преступлений и лиц, причастных к их совершению – это …', N'сбор образцов для сравнительного исследования;', N'проверочная закупка;', N'контролируемая поставка;', N'контроль почтовых отправлений, телеграфных и иных сообщений.', N'контролируемая поставка;')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (58, 11, N'Оперативный эксперимент – это …', N'способ получения информации о признаках преступной деятельности путем перемещения под контролем правоохранительных органов товаров и предметов в целях выявления пресечения преступлений и лиц, причастных к их совершению;', N'способ получения информации путем воспроизведения негласно контролируемых условий и объектов для проявления противоправных намерений лиц, обоснованно подозреваемых в подготовке или совершении тяжких и особо тяжких преступлений;', N'негласное слежение оперативного работника за лицами, причастными к совершению криминального события;', N'оперативный осмотр объектов в целях поиска следов преступной деятельности, орудий преступления, разыскиваемых лиц, а также получения информации необходимой для решения задач ОРД.', N'способ получения информации путем воспроизведения негласно контролируемых условий и объектов для проявления противоправных намерений лиц, обоснованно подозреваемых в подготовке или совершении тяжких и особо тяжких преступлений;')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (59, 11, N'Какой максимальный срок прослушивания телефонных переговоров установлен законодательством?', N'1 мес.;', N'3 мес.;', N'6 мес.;', N'1 год.', N'6 мес.;')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (60, 11, N'Допускается ли проведение оперативно-розыскных мероприятий, которые ограничивают конституционные права человека и гражданина на тайну переписки, телефонных переговоров, почтовых, телеграфных и иных сообщений, передаваемых по сетям электрической и почтовой связи, а также право на неприкосновенность жилища?', N'допускается на основании судебного решения;', N'допускается при наличии определенной информации о фактах совершения преступлении;', N'допускается на основании судебного решения и при наличии установленной законом информации;', N'не допускается.', N'допускается на основании судебного решения и при наличии установленной законом информации;')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (61, 12, N'Стоимость капитала – это', N'уровень доходности на вложенный капитал', N'прибыль, которая необходима, чтобы удовлетворить требования владельцев капитала', N'активы предприятия за минусом его обязательств', N'основные и оборотные фонды предприятия', N'уровень доходности на вложенный капитал')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (62, 12, N'Финансовому лизингу в отличие от оперативного присуще то, что', N'предмет лизинга в течение полного срока амортизации может быть неоднократно передан в лизинг', N'субъектами договора лизинга могут быть только резеденты РФ', N'лизингователь закупает оборудование по требованию лизингополучателя', N'нет верного ответа', N'лизингователь закупает оборудование по требованию лизингополучателя')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (63, 12, N'К специальному законодательству, регулирующему деятельность иностранного инвестора на территории РФ, можно отнести', N'ФЗ «об инвестиционной деятельности в форме капитальных вложений»', N'ФЗ «об иностранных инвестициях в РФ»', N'гражданский кодекс РФ', N'вашингтонскую конвенцию о разрешении споров 1965 г.', N'ФЗ «об иностранных инвестициях в РФ»')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (64, 12, N'На принятие решения об инвестировании не оказывает влияния норма амортизации', N'ожидание инфляции', N'цена потребительской корзины', N'ожидаемый спрос на продукцию', N'налоги предпринимательскую деятельность', N'цена потребительской корзины')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (65, 12, N'Если ставка дисконтирования ниже внутренней нормы доходности, то инвестирование будет', N'прибыльным', N'нейтральным', N'убыточным', N'нет верного ответа', N'прибыльным')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (66, 12, N'К иностранным инвестициям не относится', N'покупка лицензий, патентов, торговых марок иностранных компаний', N'приобретение ценных бумаг иностранных эмитентов', N'экспорт продукции', N'вложение капитала в производственные объекты за пределами страны', N'экспорт продукции')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (67, 12, N'Выбор объекта лизинга и его продавца при финансовом лизинге осуществляет по общему правилу', N'лизингодатель', N'банк-кредитор', N'страховая компания', N'лизингополучатель', N'лизингополучатель')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (68, 12, N'Неверно, что при лизинге недвижимости в РФ выделяют лизинг', N'производственных зданий и сооружений', N'промышленных предприятий', N'земельных участков', N'торговых, складских и офисных помещений', N'земельных участков')
INSERT [dbo].[Questins] ([Id_Question], [Test_Id], [Text_Question], [First_Answer], [Second_Answer], [Third_Answer], [Fourth_Answer], [Correct_Answer]) VALUES (69, 12, N'В модели Марковица для оценки инвестором эффективности вложения денег в портфель акций используются', N'ожидаемая доходность и темп инфляции', N'ковариация и коэффициент корреляции доходности акций портфеля', N'дисперсия доходности акций портфеля и темп инфляции', N'ожидаемая доходность и дисперсия доходности акций портфеля', N'ожидаемая доходность и дисперсия доходности акций портфеля')
SET IDENTITY_INSERT [dbo].[Questins] OFF
GO
SET IDENTITY_INSERT [dbo].[Tester] ON 

INSERT [dbo].[Tester] ([Id_Tester], [Full_Name_Tester], [Login_Tester], [Password_Tester]) VALUES (1, N'Белов Роман Никитич', N'2', N'2')
INSERT [dbo].[Tester] ([Id_Tester], [Full_Name_Tester], [Login_Tester], [Password_Tester]) VALUES (2, N'Емельянов Георгий Матвеевич', N'BGqB*@aur{', N'BGqB*@aur{')
INSERT [dbo].[Tester] ([Id_Tester], [Full_Name_Tester], [Login_Tester], [Password_Tester]) VALUES (3, N'Абрамов Александр Тимурович', N'{$A0XR*VC{', N'{$A0XR*VC{')
INSERT [dbo].[Tester] ([Id_Tester], [Full_Name_Tester], [Login_Tester], [Password_Tester]) VALUES (4, N'Орлова Анна Олеговна', N'VG04yV83I6', N'VG04yV83I6')
INSERT [dbo].[Tester] ([Id_Tester], [Full_Name_Tester], [Login_Tester], [Password_Tester]) VALUES (5, N'Козлова Диана Георгиевна', N'nCpSF6i9%q', N'nCpSF6i9%q')
INSERT [dbo].[Tester] ([Id_Tester], [Full_Name_Tester], [Login_Tester], [Password_Tester]) VALUES (6, N'Александрова Ксения Максимовна', N'uyu6~2r{g$', N'uyu6~2r{g$')
INSERT [dbo].[Tester] ([Id_Tester], [Full_Name_Tester], [Login_Tester], [Password_Tester]) VALUES (7, N'Леонтьев Константин Иванович', N'P#04Dqq@lc', N'P#04Dqq@lc')
INSERT [dbo].[Tester] ([Id_Tester], [Full_Name_Tester], [Login_Tester], [Password_Tester]) VALUES (8, N'Майоров Николай Давидович', N'T1Jumyvpgg', N'T1Jumyvpgg')
INSERT [dbo].[Tester] ([Id_Tester], [Full_Name_Tester], [Login_Tester], [Password_Tester]) VALUES (9, N'Сорокин Матвей Артёмович', N'XfJ}loo|%~', N'XfJ}loo|%~')
INSERT [dbo].[Tester] ([Id_Tester], [Full_Name_Tester], [Login_Tester], [Password_Tester]) VALUES (10, N'Зуева Анастасия Тимуровна', N'xnYC#5OiEM', N'xnYC#5OiEM')
SET IDENTITY_INSERT [dbo].[Tester] OFF
GO
SET IDENTITY_INSERT [dbo].[Tests] ON 

INSERT [dbo].[Tests] ([Id_Test], [Tester_Id], [Name_Test], [Time_Complete]) VALUES (1, 2, N'Компьютерные технологии', 7)
INSERT [dbo].[Tests] ([Id_Test], [Tester_Id], [Name_Test], [Time_Complete]) VALUES (2, 2, N'Windows', 1)
INSERT [dbo].[Tests] ([Id_Test], [Tester_Id], [Name_Test], [Time_Complete]) VALUES (3, 2, N'Информатика', 5)
INSERT [dbo].[Tests] ([Id_Test], [Tester_Id], [Name_Test], [Time_Complete]) VALUES (4, 2, N'Информатика продвинутый', 10)
INSERT [dbo].[Tests] ([Id_Test], [Tester_Id], [Name_Test], [Time_Complete]) VALUES (5, 2, N'Компьютерные технологии продвинутый', 10)
INSERT [dbo].[Tests] ([Id_Test], [Tester_Id], [Name_Test], [Time_Complete]) VALUES (6, 2, N'Windows продвинутый', 0)
INSERT [dbo].[Tests] ([Id_Test], [Tester_Id], [Name_Test], [Time_Complete]) VALUES (7, 4, N'Статистика в экономике', 1)
INSERT [dbo].[Tests] ([Id_Test], [Tester_Id], [Name_Test], [Time_Complete]) VALUES (8, 4, N'Борьбы с таможенными преступлениями', 2)
INSERT [dbo].[Tests] ([Id_Test], [Tester_Id], [Name_Test], [Time_Complete]) VALUES (9, 4, N'Инвестиционные вложеня. Ценные бумаги', 4)
INSERT [dbo].[Tests] ([Id_Test], [Tester_Id], [Name_Test], [Time_Complete]) VALUES (10, 4, N'Статистика в экономике продвинутый', 1)
INSERT [dbo].[Tests] ([Id_Test], [Tester_Id], [Name_Test], [Time_Complete]) VALUES (11, 4, N'Борьбы с таможенными преступлениями продвинутый', 3)
INSERT [dbo].[Tests] ([Id_Test], [Tester_Id], [Name_Test], [Time_Complete]) VALUES (12, 4, N'Инвестиционные вложеня. Ценные бумаги продвинутый', 0)
SET IDENTITY_INSERT [dbo].[Tests] OFF
GO
SET IDENTITY_INSERT [dbo].[Uzers] ON 

INSERT [dbo].[Uzers] ([Id_Uzer], [Full_Name_Uzer], [Login_Uzer], [Password_Uzer]) VALUES (1, N'Савельев Дмитрий Сергеевич', N'1', N'1')
INSERT [dbo].[Uzers] ([Id_Uzer], [Full_Name_Uzer], [Login_Uzer], [Password_Uzer]) VALUES (2, N'Алексеева Валерия Матвеевна', N'FrmqM#HK', N'FrmqM#HK')
INSERT [dbo].[Uzers] ([Id_Uzer], [Full_Name_Uzer], [Login_Uzer], [Password_Uzer]) VALUES (3, N'Федотова Ева Арсентьевна', N'@@IxaJGR', N'@@IxaJGR')
INSERT [dbo].[Uzers] ([Id_Uzer], [Full_Name_Uzer], [Login_Uzer], [Password_Uzer]) VALUES (4, N'Константинов Макар Давидович', N'2TY%g~5o', N'2TY%g~5o')
INSERT [dbo].[Uzers] ([Id_Uzer], [Full_Name_Uzer], [Login_Uzer], [Password_Uzer]) VALUES (5, N'Егоров Кирилл Михайлович', N'KRD{c77R', N'KRD{c77R')
INSERT [dbo].[Uzers] ([Id_Uzer], [Full_Name_Uzer], [Login_Uzer], [Password_Uzer]) VALUES (6, N'Федорова Кира Сергеевна', N'E@h0|%|T', N'E@h0|%|T')
INSERT [dbo].[Uzers] ([Id_Uzer], [Full_Name_Uzer], [Login_Uzer], [Password_Uzer]) VALUES (7, N'Иванов Иван Матвеевич', N'i0FaEuXt', N'i0FaEuXt')
INSERT [dbo].[Uzers] ([Id_Uzer], [Full_Name_Uzer], [Login_Uzer], [Password_Uzer]) VALUES (8, N'Захарова Ангелина Ивановна', N'MtKhGomO', N'MtKhGomO')
INSERT [dbo].[Uzers] ([Id_Uzer], [Full_Name_Uzer], [Login_Uzer], [Password_Uzer]) VALUES (9, N'Соколов Александр Кириллович', N'ecgI|||M', N'ecgI|||M')
INSERT [dbo].[Uzers] ([Id_Uzer], [Full_Name_Uzer], [Login_Uzer], [Password_Uzer]) VALUES (10, N'Иванова Софья Львовна', N'wxDQUFBY', N'wxDQUFBY')
SET IDENTITY_INSERT [dbo].[Uzers] OFF
GO
ALTER TABLE [dbo].[Questins]  WITH CHECK ADD  CONSTRAINT [FK_Questins_Tests] FOREIGN KEY([Test_Id])
REFERENCES [dbo].[Tests] ([Id_Test])
GO
ALTER TABLE [dbo].[Questins] CHECK CONSTRAINT [FK_Questins_Tests]
GO
ALTER TABLE [dbo].[Result]  WITH CHECK ADD  CONSTRAINT [FK_Result_Tests] FOREIGN KEY([Test_Id])
REFERENCES [dbo].[Tests] ([Id_Test])
GO
ALTER TABLE [dbo].[Result] CHECK CONSTRAINT [FK_Result_Tests]
GO
ALTER TABLE [dbo].[Result]  WITH CHECK ADD  CONSTRAINT [FK_Result_Uzers] FOREIGN KEY([Uzer_Id])
REFERENCES [dbo].[Uzers] ([Id_Uzer])
GO
ALTER TABLE [dbo].[Result] CHECK CONSTRAINT [FK_Result_Uzers]
GO
ALTER TABLE [dbo].[Tests]  WITH CHECK ADD  CONSTRAINT [FK_Tests_Tester] FOREIGN KEY([Tester_Id])
REFERENCES [dbo].[Tester] ([Id_Tester])
GO
ALTER TABLE [dbo].[Tests] CHECK CONSTRAINT [FK_Tests_Tester]
GO
USE [master]
GO
ALTER DATABASE [Tests] SET  READ_WRITE 
GO
