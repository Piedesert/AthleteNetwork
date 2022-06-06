Error Handling:

All responses wil be in "content-type: application/json; charset=utf-8".

Here's a list of the errors the API can respond with. Some of them will only apply if you're using an API key.

401 - Unautherized

{ "error": "Invalid API key" }
402 - Payment Required

{ "error": "Subscription is not active" }
422 - Unprocessable Entity

{ "error": "Missing 'name' parameter" }
422 - Unprocessable Entity

{ "error": "Invalid 'name' parameter" }
429 - Too Many Requests

{ "error": "Request limit reached" }
429 - Too Many Requests

{ "error": "Request limit too low to process request" }