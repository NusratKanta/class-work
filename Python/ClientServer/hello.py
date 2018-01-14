from flask import Flask
from flask import request
from pymongo import MongoClient

import os.path

app = Flask(__name__)

client = MongoClient(port=27017)
db = client.myDatabase

@app.route('/')
def hello_world():
    return 'Hello, World!'


@app.route('/getdata', methods=['GET'])
def get_data():
    with open('database.txt', 'r') as fp:
        content = fp.read()
        return content


@app.route('/postdata', methods=['POST'])
def post_data():
    # return " a data "
    content = request.json
    result = db.mydata.insert_one(content)

   
    if(os.path.isfile('database.txt')):
        with open('database.txt', 'a') as fp: 
            fp.write(content1+content2+content3+'\n')
        
    else: 
        with open('database.txt', 'w') as fp: 
            fp.write(content1+content2+content3++'\n')

    with open('database.txt', 'r') as fp:
            content = fp.read()
            return content

if __name__ == "__main__":
	app.run(host="0.0.0.0", debug=True)



# from flask import request

# @app.route('/login', methods=['GET', 'POST'])
# def login():
#     if request.method == 'POST':
#         do_the_login()
#     else:
#         show_the_login_form()
