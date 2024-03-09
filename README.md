Описание проекта Ежедневник

**Классы-участники:**
1. Поставщик/supplier (тот, у кого закупаем продукцию):
Id
Name
Prioriy - приоритетность в 3 вариантах: красный (важный), средний, зеленый (неважный)
Country - страна поставщика
Комментарии

2. Перевозчик/carrier
Id
Name
Надежность/Reliability - green (надежный), yellow (с косяками), red (редко выручает/проблемный)
Комментарий

3. Склад/Warehouse
Id
Name
Comment

**Классы-задачи**
4. Абстрактная задача (от которой будут наследоваться остальные):
abstract Id
abstract Name
abstract Comment

5. Задача : Абстр.Задача
_Id
Name
Comment_
Приоритетность
Дата начала
Дата окончания

6. Доставка : Задача
_Id
Name
Comment
Приоритетность
Дата начала
Дата окончания_
Стоимость
Стутус оплаты: оплачен, неоплачен
Статус доставки: в поиске авто, ожилание погрузки, в пути, прибыл


Описание

Ежедневник для организации рабочего процесса и отслеживания ежедневных/еженедельных/ежемесячных и иных задач.
Пользователь вносит информацию по своим поставщикам/партнерам и иным контрагентам, с которыми он работает и с которыми связаны его рабочие процессы в базу данных ежедневника.
Далее он начинает создавать задачи. 
Задачи связаны с тем или иным контрагентом, а также могут быть общими рабочими моментами (как, например, поиск нового поставщика, анализ ситуации на рынке сырья, сравнение ставок и т.д. – но это не отменяет того, что пользователь может отнести эти задачи к любому из контрагентов). Ежедневник сохраняет эти данные в своей БД, и со временем при внесении пользователем новой задачи, похожей на предыдущие, программа будет предлагать шаблоны для заполнения.
Каждая задача будет иметь приоритетность и прогресс выполнения для отслеживания эффективности. При задержке или откладывании такая задача будет подсвечиваться пользователю при его желании, чтобы он помнил о ней, и обратил пристальное внимание на нее.
При просрочке задачи будут автоматически переносится на следующий день, давая о себе знать утром, при включении программы.
У каждой задачи имеется параметр времени. Таким образом можно отслеживать сроки выполнения задачи, дату ее создания и окончания.
А также в программе будут различные утилиты по визуализации прогресса…


**Таблицы (базы):**
Поставщики
Перевозчики
Склады (склады только нашей компании)
Задачи
Доставки

В таблицах можно настроить сортировку по своему желанию по тому параметру, который доступен.
