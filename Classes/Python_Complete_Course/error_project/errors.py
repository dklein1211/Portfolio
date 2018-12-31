class RuntimeErrorCode(TypeError):
    """Exception raised when a specific error code is needed. Doc String Used for creating documentation."""
    def __init__(self, message, code):
        super().__init__(f'Error code {code}: {message}')
        self.code = code


err = RuntimeErrorCode('Custom Error Info', 500)
print(err.__doc__)