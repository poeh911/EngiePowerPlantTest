to build and launch the API please run these command:

```ps1 
cd EngiePowerPlantTest
docker build -t engie-test .
docker run -p 8888:80 --rm engie-test
```