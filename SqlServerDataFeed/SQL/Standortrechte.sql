
SELECT 
	 T_AP_Standort.SO_Nr 
	,T_Benutzergruppen.Name 
	,T_SYS_Standortrechte.SOR_IsRead 
FROM T_SYS_Standortrechte 

LEFT JOIN T_Benutzergruppen 
	ON T_Benutzergruppen.ID = T_SYS_Standortrechte.SOR_GRANTEE_ID 

LEFT JOIN T_AP_Standort 
	ON T_AP_Standort.SO_UID = T_SYS_Standortrechte.SOR_SO_UID 

WHERE T_AP_Standort.SO_Nr = '6002' 

ORDER BY SO_Nr, Name, SOR_IsRead 
