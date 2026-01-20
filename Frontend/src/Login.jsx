export default function Login() {
  return (
    <>
      <section className="bg-dark">
        <div className="container bg-dark text-light" id="login-form">
          <form>
            <div class="mb-3">
              <label for="exampleInputEmail1" class="form-label">
                ID de Usuario
              </label>
              <input class="form-control" aria-describedby="emailHelp" />
              <div id="emailHelp" class="form-text">
                We'll never share your email with anyone else.
              </div>
            </div>
            <div class="mb-3">
              <label for="exampleInputPassword1" class="form-label">
                Contraseña
              </label>
              <input
                type="password"
                class="form-control"
                id="exampleInputPassword1"
              />
            </div>
            <button type="submit" class="btn btn-primary">
              Login
            </button>
          </form>
        </div>
      </section>
    </>
  );
}
