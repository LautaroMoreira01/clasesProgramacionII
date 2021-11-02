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
--Los puestos con nivel de autorización 0, 1 o 2.
--Los puestos con nivel de autorización distinto a 0, 1 y 2.
--Los empleados activos ordenados alfabéticamente por su apellido de manera ascendente.
--Los tres empleados más viejos.
--Los tres empleados que más ganan.
--Todos los datos de los empleados ordenados por el valor de sus salarios de manera descendente.
--Los distintos niveles de autorización de los puestos, sin repetir.