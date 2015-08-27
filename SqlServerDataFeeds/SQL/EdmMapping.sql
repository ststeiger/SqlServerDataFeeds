
DECLARE @__in_table_name nvarchar(128)
SET @__in_table_name = N'___AllTypes' 


SELECT 

	 --table_schema
	--,table_name
	 column_name
	--,ordinal_position
	--,column_default
	--,is_nullable
	--,data_type
	
	,CASE WHEN is_nullable = 'YES'
		THEN NULL 
		ELSE 'false' 
	END AS EntityNullable
	
	,CASE 
		WHEN DATA_TYPE = 'bigint' THEN 'Edm.Int64'
		WHEN DATA_TYPE = 'binary' THEN 'Edm.Binary'
		WHEN DATA_TYPE = 'bit' THEN 'Edm.Boolean'
		WHEN data_type IN ('char', 'nchar','varchar', 'nvarchar','text', 'ntext') THEN 'Edm.String' 
		WHEN DATA_TYPE = 'date' THEN 'Edm.DateTime'
		WHEN DATA_TYPE = 'smalldatetime' THEN 'Edm.DateTime'
		WHEN DATA_TYPE = 'datetime' THEN 'Edm.DateTime'
		WHEN DATA_TYPE = 'datetime2' THEN 'Edm.DateTime'
		WHEN DATA_TYPE = 'datetimeoffset' THEN 'Edm.DateTimeOffset'
		WHEN DATA_TYPE = 'decimal' THEN 'Edm.Decimal'
		WHEN DATA_TYPE = 'float' THEN 'Edm.Double'
		WHEN DATA_TYPE = 'image' THEN 'Edm.Binary'
		WHEN DATA_TYPE = 'int' THEN 'Edm.Int32'
		WHEN DATA_TYPE = 'money' THEN 'Edm.Decimal'
		WHEN DATA_TYPE = 'numeric' THEN 'Edm.Decimal'
		WHEN DATA_TYPE = 'real' THEN 'Edm.Single'
		WHEN DATA_TYPE = 'smallint' THEN 'Edm.Int16'
		WHEN DATA_TYPE = 'smallmoney' THEN 'Edm.Decimal'
		WHEN DATA_TYPE = 'time' THEN 'Edm.Time'
		WHEN DATA_TYPE = 'timestamp' THEN 'Edm.Binary'
		WHEN DATA_TYPE = 'tinyint' THEN 'Edm.Byte'
		WHEN DATA_TYPE = 'uniqueidentifier' THEN 'Edm.Guid'
		WHEN DATA_TYPE = 'varbinary' THEN 'Edm.Binary'
		WHEN DATA_TYPE = 'xml' THEN 'Edm.String'
		
		ELSE 'n.def.'
	END AS EntityType 
	
	,CASE 
		WHEN data_type IN ('image', 'xml') THEN 'Max' 
		WHEN data_type IN ('char', 'nchar','varchar', 'nvarchar','text', 'ntext')
			 AND (character_maximum_length > 100000 OR character_maximum_length = -1)
				THEN 'Max' 
		WHEN data_type IN ('char', 'nchar','varchar', 'nvarchar','text', 'ntext')
			THEN CAST(character_maximum_length AS varchar(30)) 
		WHEN data_type IN ('binary', 'varbinary')
			THEN 
				CASE 
					WHEN character_octet_length < 0 THEN 'Max' 
					ELSE CAST(character_octet_length AS varchar(30)) 
				END 
		ELSE NULL 
	END AS EntityMaxLength
	
	,
	CASE 
		WHEN data_type IN ('image', 'xml') THEN 'false' 
		WHEN data_type IN ('varchar', 'nvarchar','text', 'ntext', 'varbinary', 'xml') THEN 'false' 
		WHEN data_type IN ('char', 'nchar', 'binary') THEN 'true' 
		ELSE NULL 
	END AS EntityFixedLength
	
	,CASE 
		WHEN data_type IN ('nchar', 'nvarchar', 'ntext', 'xml') THEN 'true' 
		WHEN data_type IN ('char', 'varchar', 'text') THEN 'false'
		ELSE NULL 
	END AS EntityUnicode 
	
	,
	CASE 
		WHEN data_type IN ('bigint', 'int', 'smallint', 'tinyint') THEN NULL 
		WHEN datetime_precision IS NOT NULL THEN datetime_precision 
		ELSE numeric_precision 
	END AS EntityPrecision 
	
	,
	CASE 
		WHEN data_type IN ('bigint', 'int', 'smallint', 'tinyint') THEN NULL 
		ELSE numeric_scale 
	END AS EntityScale
	
	--,character_maximum_length
	--,character_octet_length
	--,numeric_precision
	--,numeric_precision_radix

	--,character_set_catalog
	--,character_set_schema
	--,character_set_name
	--,collation_catalog
	--,collation_schema
	--,collation_name
FROM INFORMATION_SCHEMA.COLUMNS 
WHERE TABLE_NAME = @__in_table_name 
ORDER BY ORDINAL_POSITION 
