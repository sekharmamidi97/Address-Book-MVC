Create table Information
(
	info_id int identity(1,1) not null primary key,
	first_name varchar(5000) not null,
	middle_name varchar(5000) null,
	last_name varchar(5000) not null,
	professional_title varchar(5000) null,
	age int null,
	home_address varchar(5000) not null,
	work_address varchar(5000) null,
	other_address varchar(5000) null,
	home_phone_number int not null, --changed datatype to varchar
	work_phone_number int null,     --changed datatype to varchar
	mobile_phone_number int null,   --changed datatype to varchar
	personal_email_address varchar(5000) null,
	work_email_address varchar(5000) null,
	other_email_address varchar(5000) null,
	linkedin varchar(5000) null,
	website varchar(5000) null,
	twitter varchar(5000) null,
	facebook varchar(5000) null,
	);

	Alter table Information
	Alter column home_phone_number varchar(20)

	Alter table Information
	Alter column work_phone_number varchar(20)

	Alter table Information
	Alter column mobile_phone_number varchar(20)

	Insert Into Information(first_name, middle_name, last_name, professional_title, age, home_address, work_address, other_address, home_phone_number, work_phone_number, mobile_phone_number, personal_email_address, work_email_address, other_email_address, linkedin, website, twitter, facebook)
	Values('Joseph', 'Doe', 'SeeMoreButts', 'Photographer', 45, '1234 Practical Lane, Cleveland, OH 44115', '9876 Foodway Road, Cleveland, OH 44105', 'null', '5555555555', '1111111111', '4444444444', 'jdsb@gmail.com', 'jdsb@photo.com', 'null', 'null', 'null', '@jdsb', 'null'),
	('Jane', 'Erica', 'SeeMoreButts', 'Model', 40, '1234 Practical Lane, Cleveland, OH 44115', '9876 Foodway Road, Cleveland, OH 44105', 'null', '5555555555', '1111111111', '6666666666', 'jesb@gmail.com', 'jesb@photo.com', 'null', 'null', 'null', '@jesb', 'null');

