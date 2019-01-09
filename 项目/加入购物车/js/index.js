var index;

var request = new XMLHttpRequest();
request.open('GET', 'index.json');
request.responseType = 'json';

request.onload = function() {
  if(request.status === 200) {
    index = request.response;
    console.log(index);
    newindex();//调用返回类型
  } else {
    console.log('Network request for index.json failed with response ' + request.status + ': ' + request.statusText)
  }
};

request.send();//发送请求

function newindex(){

}