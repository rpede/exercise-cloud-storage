import "./App.css";

function App() {
  return (
    <div className="flex min-h-full flex-col justify-center px-6 py-12 lg:px-8">
      <div className="sm:mx-auto sm:w-full sm:max-w-sm ">
        <h2 className="mt-10 text-center text-2xl font-bold leading-9">
          Image Uploader
        </h2>
      </div>

      <div className="carousel rounded-box">
        {[, , , ,].map((image) => (
          <div className="carousel-item">
            <img src="https://placehold.co/400" />
          </div>
        ))}
      </div>

      <div className="mt-10 sm:mx-auto sm:w-full sm:max-w-sm">
        <div className="mt-2">
          <input
            type="file"
            className="file-input w-full"
            onChange={(e) => e.target.files?.[0]}
          />
        </div>

        <button
          className="btn btn-primary w-full justify-center mt-6"
          onClick={(e) => {}}
        >
          Upload
        </button>
      </div>
    </div>
  );
}

export default App;
