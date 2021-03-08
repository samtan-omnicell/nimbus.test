#Requirements:
1. ASP.net core 5 SDK; you can download it here:
https://dotnet.microsoft.com/download/dotnet/5.0

2. Enable Kubernentes on Docker Desktop; you can find docker desktop here:
https://www.docker.com/products/docker-desktop

3. Docker Hub account with a public repository called "nimbus.test"
https://hub.docker.com

#To Run
1. Build the docker image from the Dockerfile found in the nimbus.test directory
- t argument sets the docker image name to "samtanomnicell/nimbus.test:v1"
- the next argument tells docker to use the Dockerfile found in the nimbus.test directory
'''
docker build -t {Your Docker Hub User ID}/nimbus.test:v1 ./nimbus.test
'''

2. Push the image to your Docker Hub Repo
- By default kubectl apply will pull images from Docker Hub Registry
- Pushing the image to Docker Hub will allow K8s access to your Docker image
'''
docker push {Your Docker Hub User ID}/nimbus.test:v1
'''

3. Change the deployment.yaml file to point to your own Docker Hub repo
- Right now the deployment.yaml file points to my own Docker Hub Repo
- see line 36 and reference your own image in Docker Hub

4. Apply the ingress and the pod to the K8s cluster in Docker Desktop
'''
kubectl apply -f deployment.yaml
'''

5. Go to your browser and try to access the endpoint
- HTTPS will not work without a certificate
- the response to ping is pong.
'''
http://localhost:5000/ping
'''