use scottnew;
select * from scottnew.emps;

-- A1
select * from scottnew.depts;

-- A2
select ENAME, JOB, HIREDATE from scottnew.emps where dept_id=10;

-- A3
select ENAME, JOB, SAL from scottnew.emps where JOB='CLERK';

-- A4
select * from scottnew.emps where dept_id!=10;

-- A5
select ENAME from scottnew.emps where COMM>SAL;

-- A6
select ENAME from scottnew.emps where HIREDATE='1981-12-03';

-- A7
select ENAME, SAL from scottnew.emps where SAL<1250 || SAL>1600;

-- A8
select ENAME from scottnew.emps where JOB!='Manager' && JOB!='Präsident';

-- A9
select ENAME from scottnew.emps where ENAME like '__a%';

-- A10
select id, ENAME, JOB from scottnew.emps where COMM!='<null>';

-- A11
select id, ENAME, COMM from scottnew.emps order by COMM desc;

-- A12
select * from scottnew.emps where !(JOB='Manager' OR JOB='President') order by dept_id, HIREDATE;

-- A13
select ENAME from scottnew.emps where length(ENAME)=6;

-- A14
select concat(ENAME,'-',JOB) AS 'NeueÜberschrift' from scottnew.emps where dept_id=30;

-- A15
select SAL+COMM from scottnew.emps;
select SAL+IFNULL(emps.COMM,0) from scottnew.emps;
-- if null gets replaced by 0 before adding

-- A16
select ENAME, SAL as MONTHLY, SAL/28 as DAILY, (SAL/28)/8 as HOURLY from emps;

-- A17
select SUM(SAL) as TotalSAL from emps;

-- A18
select AVG(IFNULL(emps.COMM,250)) as AVGCOMM from emps;

-- A19
select COUNT(SAL), COUNT(case when COMM>0 then 1 end) from scottnew.emps where dept_id='30';

-- A20
select COUNT(distinct JOB) from emps;

-- A21
-- version eins gibt die distinct werte aus version 2 zählt sie

-- A22
select SUM(SAL), AVG(SAL), COUNT(SAL), SUM(IFNULL(emps.COMM,0)), AVG(IFNULL(emps.COMM,250)), COUNT(IFNULL(emps.COMM,250)) from scottnew.emps where emps.dept_id=30;

-- A23
select COUNT(JOB) from emps where !(Job='Manager' and Job='Präsident') group by dept_id;

-- A24
SELECT AVG(emp_count) AS avg_employees_per_dept
FROM (
         SELECT dept_id, COUNT(*) AS emp_count
         FROM scottnew.emps
         GROUP BY dept_id
     ) AS dept_counts;

-- A25
select * from emps where JOB='Manager' or JOB='President';

-- A26
SELECT ENAME, JOB, COMM FROM emps WHERE (SAL * 0.25) < COMM;

-- A27
select MIN(SAL+COMM) from emps;

-- A28
select MIN(emps.HIREDATE) as oldestEmployee from emps;

-- A29
select Count(id), JOB, dept_id from emps group by dept_id,JOB order by dept_id, JOB;

-- A30
SELECT min(max) from (select max(SAL) as max from emps group by dept_id) as x;

-- A31
-- null ist keine provision 0 ist eine provision im wert von 0

-- A32
-- count(*) zählt alle zeilen, count(parent_id) zählt alle parent_ids, count distinct parent id zählt alle einzigartigen parent ids

-- A33
-- GROUP BY und Aggregatfunktionen wie COUNT(), SUM(), AVG(), MIN() und MAX()

-- A34
select MIN(SAL), MIN(COMM), MAX(SAL), MAX(COMM), AVG(SAL), AVG(COMM), COUNT(SAL), COUNT(COMM) from emps where dept_id = 30;

-- A35
select MIN(SAL), MAX(SAL), AVG(SAL) from emps group by dept_id;

-- A36
select MIN(SAL), MAX(SAL), AVG(SAL), COUNT(ENAME) from emps where !(JOB='Manager' or JOB='President') group by dept_id;

-- A37
select JOB, AVG(SAL) from emps where COMM IS NULL group by JOB;

-- A38
select (SAL+IFNULL(COMM, 100))*12  as GesamtJahreszahlung from emps;

-- A39
-- in mysql nicht möglich
-- von innen nach außen ausgeführt (subselect)

-- A40
select JOB, AVG(SAL) as Durchschnittseinkommen from emps group by JOB HAVING AVG(SAL) > 1500 order by AVG(SAL);

-- A41
select dept_id from emps where JOB='CLERK' group by dept_id HAVING COUNT(SAL)>=2;

-- A42
-- where gilt für einzelne having gilt für zeilen/gruppen

-- A43
select JOB, AVG(SAL) as Durchschnittseinkommen from emps group by JOB HAVING AVG(SAL) > 1500 order by JOB;

-- A44
-- where dann having

-- A45
-- für where brauch ich kein group by

-- A46
select SAL from emps where SAL>(select SAL from emps where ENAME='JONES');

-- A47
select e.ENAME, e.SAL, (select ENAME from emps where id = e.parent_id) as Vorgesetzter from emps e where SAL>(select SAL from emps where id = e.parent_id);
select e.ENAME, e.SAL, a.ENAME, a.SAL from emps e join emps a on e.id=a.parent_id where a.SAL>e.SAL;

-- A48
select e.SAL from emps e where SAL*0.3<(select SAL from emps where id = e.parent_id and JOB='President');
select e.SAL, e.ENAME from emps e join emps a on e.parent_id=a.id where e.SAL*0.3<a.SAL and a.JOB='President';

-- A49
select e.DEPTNO from depts e where (select count(*) from emps where dept_id=e.DEPTNO)=0;
select DEPTNO as counted from depts d left join emps on dept_id = DEPTNO group by DEPTNO having count(id) = 0;

-- A50
select ENAME from emps where JOB = (select JOB from emps where ENAME='JONES') and ENAME != 'JONES';

-- A51
Select ENAME, JOB, SAL from emps where SAL=(select MAX(SAL) from emps);

-- A52
select ENAME FROM emps where CHAR_LENGTH(ENAME) = (select Max(Char_Length(Ename))from emps);

-- A53
select Count(id) from emps where dept_id = (select DEPTNO from depts where LOC='NEW YORK');

-- A54
select ENAME from emps where dept_id = (select DEPTNO from depts where LOC='NEW YORK');

-- A55
select ENAME from emps where dept_id = (select DEPTNO from depts where LOC='CHICAGO') and JOB=(select JOB from emps where ENAME='ALLEN');

-- A56
select JOB from emps group by JOB having avg(SAL)>(Select AVG(SAL) from emps where JOB = 'SALESMAN');

-- A57
select e.ENAME, e.JOB from emps e where e.JOB = (select JOB from emps where dept_id=30 and JOB=e.JOB) and e.dept_id =10;
SELECT DISTINCT e.ENAME, e.JOB FROM emps e JOIN emps x ON e.JOB = x.JOB WHERE e.dept_id = 10 AND x.dept_id = 30;

-- A58
select e.ENAME, e.JOB from emps e where e.JOB != (select JOB from emps where dept_id=30 and JOB=e.JOB) and e.dept_id =10; -- wrong
select e.ENAME, e.JOB from emps e join emps a on e.JOB=a.JOB where e.dept_id=10 and a.dept_id!=30; -- wrong
SELECT e.ename, e.job FROM emps e WHERE e.job IN (SELECT job FROM emps WHERE dept_id = 10)AND e.job NOT IN (SELECT job FROM emps WHERE dept_id = 30);

-- A59
SELECT e.ENAME, e.JOB FROM emps e WHERE e.JOB IN (SELECT JOB FROM emps WHERE dept_id = '30');

-- A60
select e.ENAME, dept_id from emps e where HIREDATE=(select HIREDATE from emps where dept_id=e.dept_id order by HIREDATE desc limit 1)order by dept_id;
SELECT e.ENAME, e.dept_id, e.HIREDATE FROM emps e JOIN (SELECT dept_id, MAX(HIREDATE) AS max_hire FROM emps GROUP BY dept_id) m ON e.dept_id = m.dept_id AND e.HIREDATE = m.max_hire ORDER BY e.dept_id;

-- A61
select Distinct e.dept_id from emps e join depts d on e.dept_id = d.deptno;

-- A62
select e.ENAME, e.SAL, e.dept_id from emps e where e.SAL>=(select AVG(SAL)from emps where e.dept_id=dept_id group by e.dept_id);
select e.ENAME, e.SAL, e.dept_id from emps e join (select dept_id, Avg(SAL) as AVGSAL from emps group by dept_id) a on e.dept_id = a.dept_id where a.AVGSAL<=e.SAL;