import requests

data_dic = {"sensor_data": "first data"}

jsonData={
    'name': "Temp",
    'id': 1,
    'value': 25.5 
}

response = requests.post("http://127.0.0.1:5000/postdata", data = jsonData)
#response = requests.get("http://127.0.0.1:5000/getdata")
print(response.text)