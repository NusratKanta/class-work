from flask import Flask, request

app = Flask(__name__)

@app.route('/')
def index():
    return "Server is running, Method %s" % request.method

@app.route('/morshed')
def morshed():
    return "Hey Morshed!"

@app.route('/users/<name>')
def user(name):
    return "Hey %s" % name

if __name__ == "__main__":
    app.run()