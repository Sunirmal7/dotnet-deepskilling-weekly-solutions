import React, { useState } from 'react';
import BookDetails from './components/BookDetails';
import BlogDetails from './components/BlogDetails';
import CourseDetails from './components/CourseDetails';

function App() {
  const [activeComponent, setActiveComponent] = useState('');

  const renderComponent = () => {
    if (activeComponent === 'book') return <BookDetails />;
    if (activeComponent === 'blog') return <BlogDetails />;
    if (activeComponent === 'course') return <CourseDetails />;
    return <h2>Please select a component to display.</h2>;
  };

  return (
    <div style={{ padding: '20px' }}>
      <h1>Conditional Rendering in Blogger App</h1>
      <button onClick={() => setActiveComponent('book')}>Book Details</button>
      <button onClick={() => setActiveComponent('blog')}>Blog Details</button>
      <button onClick={() => setActiveComponent('course')}>Course Details</button>
      <div style={{ marginTop: '20px' }}>
        {renderComponent()}
      </div>
    </div>
  );
}

export default App;
