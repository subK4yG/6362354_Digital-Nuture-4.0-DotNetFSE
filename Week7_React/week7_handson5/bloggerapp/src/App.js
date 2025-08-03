import React from 'react';
import './App.css';
import CourseDetails from './components/CourseDetails';
import BookDetails from './components/BookDetails';
import BlogDetails from './components/BlogDetails';

function App() {
  return (
    <div className="App">
      <div className="container">
        <CourseDetails />
        <div className="divider" />
        <BookDetails />
        <div className="divider" />
        <BlogDetails />
      </div>
    </div>
  );
}

export default App;
