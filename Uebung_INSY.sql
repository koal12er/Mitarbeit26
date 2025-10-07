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

