create database cajero;
use cajero;

create table if not exists cuentas (
	id_cuenta int auto_increment unique,
    nombre_usuario varchar(255) not null,
    pin varchar(4) not null unique,
    dinero double not null
);

insert into cuentas (nombre_usuario, pin, dinero) values ("Kevin Sánchez", "0602", 500.00);
insert into cuentas (nombre_usuario, pin, dinero) values ("Jorge Pérez", "9876", 1205.00);
insert into cuentas (nombre_usuario, pin, dinero) values ("Lola González", "1423", 1405.00);
insert into cuentas (nombre_usuario, pin, dinero) values ("Victor Flores", "2314", 5005.00);
insert into cuentas (nombre_usuario, pin, dinero) values ("Joel Martínez", "6789", 2500.00);

select dinero from cuentas where pin="0602";
update cuentas set dinero= 500 where pin= "0602";