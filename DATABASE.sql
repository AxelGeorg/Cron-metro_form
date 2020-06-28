drop database Relogio;
create database Relogio;
use Relogio;

drop table historicos;
create table historicos(
	cro_id int(14) primary key auto_increment,
    cro_data varchar(28) not null,
    cro_horario varchar(28) not null,
    cro_tempo varchar(28) not null
);

insert into historicos (cro_data,cro_horario,cro_tempo) values ('28/06/2020','15:19','00:00:07.544');

select * from historicos;