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

-- ???