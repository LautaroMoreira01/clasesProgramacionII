use EMPRESA_DB 

insert into PUESTOS (ID_PUESTO , NOMBRE , NIVEL_AUTORIZACION)
values (1 , 'Director' , 3)
insert into PUESTOS (ID_PUESTO , NOMBRE , NIVEL_AUTORIZACION)
values (2 , 'Gerente' , 3)
insert into PUESTOS (ID_PUESTO , NOMBRE , NIVEL_AUTORIZACION)
values (5 , 'Jefe de sector' , 2)
insert into PUESTOS (ID_PUESTO , NOMBRE , NIVEL_AUTORIZACION)
values (4 , 'Administrativo' ,1)
insert into PUESTOS (ID_PUESTO , NOMBRE , NIVEL_AUTORIZACION)
values (3 , 'Vendedor' , 0)
insert into PUESTOS (ID_PUESTO , NOMBRE , NIVEL_AUTORIZACION)
values (6 , 'Secretario' , 2)

select * from PUESTOS

insert into EMPLEADOS(NOMBRE, APELLIDO, ID_PUESTO , SALARIO , ESTA_ACTIVO , FECHA_ALTA , FECHA_BAJA , MAIL)
values 
('Leilani', 'Kinney' , 1 , 383946.80 , 1,'1996-03-21', NULL ,'lkinney@gmail.com'),
('Igor', 'England' , 5 , 283558.85 , 1,'2013-03-28', NULL ,'	iengland@hotmail.com'),
('Maya', 'Brock' , 3 , 	164546.09 , 1,'1993-10-24', NULL ,NULL),
('Hayden', 'Moss' , 4 , 211695.50 , 0,'2012-06-07','2015-02-19','hnoss@gmail.com'),
('Amal', 'Colon' , 2, 388933.60 , 1,'2019-09-23', NULL ,NULL);

--CONSULTAS

--SELECT
-- trae el nombre y apellido de la tabla empleados donde el id empleado es 1
--SELECT NOMBRE , APELLIDO FROM EMPLEADOS WHERE ID_EMPLEADO = 1

--INSERT usando SELECT 

--comodin %
-- %a% palabra que contenga a o A
-- a% palabra que comienxe con a
-- %a palabra que termine con a

--comodin _
-- _a% palabra que contenga UNA letra antes de una a y despues de la a tenga cualquier cosa

--Select nombre from EMPLEADOS where NOMBRE like '_a%'

--PUNTO 4
--TODOS LOS EMPLEADOS
Select * from EMPLEADOS;
-- los nombres de los puestos
Select NOMBRE from PUESTOS;
-- los empleados que estan activos
Select * from EMPLEADOS where ESTA_ACTIVO = 1;
--empleados donde el salario es mayor a 200000
Select * from EMPLEADOS where SALARIO > 200000;
--empleados donde la fecha de alta es menor o igual a 2012-06-07
Select * from EMPLEADOS where FECHA_ALTA <= '2012-06-07';
--empleados que no tengan el mail cargado
Select * from EMPLEADOS where MAIL is NULL;
--empleados que si tengan el mail 
Select * from EMPLEADOS where MAIL is not NULL;
--empleados que  el mail sea gmail
Select * from EMPLEADOS where MAIL like '%gmail%';
--empleados que cuyo apellido empicece con la letra B
Select * from EMPLEADOS where APELLIDO like 'B%';

-- OPERADORES LOGICOS 
-- and &
-- or |
-- OTROS OPERADORES 
-- between entre 
-- notbetween no entre
-- in sea uno de los valores 
--notin

--ORDENAMIENTO
--order by APELLIDO ASC o DESC 

--distinc los valores que estan repetidos te los trae una sola vez
--TOP primeros 3

--PUNTO 5 Y 6

--Los empleados que estén activos y ganen más de $300.000,00.
select * from EMPLEADOS where ESTA_ACTIVO = 1 AND SALARIO > 300000

--Los empleados que no tengan mail o no estén activos.
select * from EMPLEADOS where MAIL is NULL AND ESTA_ACTIVO = 0;

--Los empleados que tengan mail y su nombre contenga la letra "a".
select * from EMPLEADOS where MAIL is not NULL AND NOMBRE like '%a%';

--Los empleados que ganen $250.000,00 o más y hayan ingresado después del año 2000 inclusive, o aquellos que ganen menos de $250.000,00 
--y hayan ingresado antes del año 2000 sin incluir.
select * from EMPLEADOS where (SALARIO >= 250000 AND FECHA_ALTA >= '2000-01-01') or (SALARIO < 250000 AND FECHA_ALTA < '2000-01-01');

--Los empleados cuyo salario esté entre $100.000,00 y $250.000,00.
select * from EMPLEADOS where SALARIO between 10000 and 250000;

--Los empleados cuyo salario NO esté entre $100.000,00 y $250.000,00.
select * from EMPLEADOS where SALARIO not between 10000 and 250000;

--Los puestos con nivel de autorización 0, 1 o 2.
-- select * from PUESTOS where NIVEL_AUTORIZACION between 0 and 2;
select * from PUESTOS where NIVEL_AUTORIZACION in (0,1, 2);

--Los puestos con nivel de autorización distinto a 0, 1 y 2.
select * from PUESTOS where NIVEL_AUTORIZACION not in (0,1, 2);
--Los empleados activos ordenados alfabéticamente por su apellido de manera ascendente.
select * from EMPLEADOS order by APELLIDO 

--Los tres empleados más viejos.
select top(3) * from EMPLEADOS order by FECHA_ALTA 
--Los tres empleados que más ganan.
select top(3) * from EMPLEADOS order by SALARIO desc

--Todos los datos de los empleados ordenados por el valor de sus salarios de manera descendente.
select * from EMPLEADOS order by SALARIO desc

--Los distintos niveles de autorización de los puestos, sin repetir.
select distinct NIVEL_AUTORIZACION as 'Nivel autorizacion' from PUESTOS ;

--JOINS

-- Inner join
-- Select nombre , apellido from Empleados e

--Left join 

--Right join


--PUNTO 7
-- nombre y apellido de los empleados, junto al nombre de su puesto.
 select e.* , p.NIVEL_AUTORIZACION from EMPLEADOS e  
inner join PUESTOS p 
ON p.ID_PUESTO = e.ID_PUESTO ;
-- los empleados que tengan un puesto con nivel de autorizacion igual a 3
select e.* , p.NIVEL_AUTORIZACION from EMPLEADOS e  
inner join PUESTOS p 
ON p.ID_PUESTO = e.ID_PUESTO where p.NIVEL_AUTORIZACION = 3

--el nombre y apellido de los empleados junto al nombre de su puesto, ordenados alfabeticamente por apellido del empleado de manera asc
select e.NOMBRE, e.APELLIDO , p.NOMBRE from EMPLEADOS e  
inner join PUESTOS p 
ON p.ID_PUESTO = e.ID_PUESTO order by e.APELLIDO asc

--nombre y apelldio de los empleados junto al  nombre de su puesto ordenados alfabeticamente por nombre del puesto de manera asc
select e.NOMBRE, e.APELLIDO , p.NOMBRE from EMPLEADOS e  
inner join PUESTOS p 
ON p.ID_PUESTO = e.ID_PUESTO order by p.NOMBRE asc

--nombre apellido y nombre de puesto de los empleados que esten activos, ordenados por su nivel de autorizacion de forma asc
select e.NOMBRE, e.APELLIDO , p.NOMBRE from EMPLEADOS e  
inner join PUESTOS p 
ON p.ID_PUESTO = e.ID_PUESTO where e.ESTA_ACTIVO = 1 order by p.ID_PUESTO asc

--los puestos que no tengan empleados asociados 
select p.* from PUESTOS p
left join  EMPLEADOS e
ON p.ID_PUESTO = e.ID_PUESTO 
where ID_EMPLEADO is null

-- los puestos que tengan empleados asociados
select distinct p.* from PUESTOS p
inner join  EMPLEADOS e
ON p.ID_PUESTO = e.ID_PUESTO 
where ID_EMPLEADO is not null

--PUNTO 8 TAREA

--promedio salarios de empleados que esten acticos
--suma de salario de empleados activos
--cantidad de empleados que esten activos

--PUNTO 9 TAREA

--Punto 10 16
select * from PUESTOS

select * from EMPLEADOS
UPDATE EMPLEADOS SET MAIL = 'mbrock@yahoo.com' WHERE ID_EMPLEADO = 28;

UPDATE EMPLEADOS SET ID_PUESTO = 4 , SALARIO = 210000  WHERE ID_EMPLEADO = 28;