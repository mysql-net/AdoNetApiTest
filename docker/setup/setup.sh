#!/bin/bash
echo 'setup.sh'
docker exec ado-mssql-1 /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P P@ssw0rd -Q "create database mssqlclient;"
docker exec ado-mssql-1 /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P P@ssw0rd -Q "create database mssqlclient2;"
docker exec ado-mssql-1 /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P P@ssw0rd -Q "create database mssqlclient3;"
docker exec ado-mssql-1 /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P P@ssw0rd -Q "create database sqlclient;"
docker exec ado-mssql-1 /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P P@ssw0rd -Q "create database sqlclientbcl;"
docker exec ado-mysql-1 mysql -uroot -ptest -e "create schema dotconnect collate utf8mb4_bin;"
docker exec ado-mysql-1 mysql -uroot -ptest -e "create schema mysqlconnector collate utf8mb4_bin;"
docker exec ado-mysql-1 mysql -uroot -ptest -e "create schema mysqldata collate utf8mb4_bin;"
docker exec ado-mysql-1 mysql -uroot -ptest -e "create schema mysqldata8 collate utf8mb4_bin;"
docker exec -e PGPASSWORD=test ado-postgres-1 psql -U root -c "CREATE DATABASE dotconnect;"
docker exec -e PGPASSWORD=test ado-postgres-1 psql -U root -c "CREATE DATABASE npgsql4;"
docker exec -e PGPASSWORD=test ado-postgres-1 psql -U root -c "CREATE DATABASE npgsql5;"
docker exec -e PGPASSWORD=test ado-postgres-1 psql -U root -c "CREATE DATABASE npgsql6;"
echo 'done'