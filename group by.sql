SELECT TOP (1000)
	  Depot.D_Name,
	  Depot.D_Location,
      COUNT(Job.J_Id) AS NumberOfJobs
  FROM 
  Job         INNER JOIN  Depot
  ON Job.D_Id     =       Depot.D_Id

  GROUP BY Depot.D_Name,Depot.D_Location;
