-- DDL 
CREATE DATABASE flights;
SHOW DATABASES;
use flights;

select * from llegadas;
select * from salidas;

-- Creacion de tablas

CREATE TABLE  llegadas(
	id int primary key auto_increment,
    hora time not null,
    desde varchar(50) not null,
    vuelo_no varchar(20),
    observaciones varchar(255)
);

CREATE TABLE salidas(
	id int primary key auto_increment,
    hora time not null,
    hasta varchar(50) not null,
    vuelo_no varchar(20),
    puerta varchar(10),
    observaciones varchar(255)
);

-- Insertar datos llegada

INSERT INTO llegadas (hora, desde, vuelo_no, observaciones)
VALUES
('10:00:00', 'New York', 'ABC123', 'On time'),
('11:00:00', 'London', 'DEF456', 'Delayed'),
('12:00:00', 'Paris', 'GHI789', 'On time'),
('1:00:00', 'Berlin', 'JKL012', 'Cancelled'),
('2:00:00', 'Tokyo', 'MNO345', 'On time');

-- Insertar datos salidas

INSERT INTO salidas (hora, hasta, vuelo_no, puerta, observaciones)
VALUES 
("08:30:00", "New York", "DL123", "D12", "On Time"),
("09:45:00", "London", "BA789", "A5", "Delayed"),
("11:00:00", "Paris", "AF234", "C8", "On Time"),
("12:15:00", "Dubai", "EK567", "B6", "Cancelled"),
("01:30:00", "Tokyo", "JL456", "E9", "On Time");