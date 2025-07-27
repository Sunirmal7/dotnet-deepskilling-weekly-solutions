import React, { Component } from 'react';

class Posts extends Component {
  constructor(props) {
    super(props);
    this.state = { posts: [], error: null };
  }

  loadPosts = async () => {
    try {
      const res = await fetch('https://jsonplaceholder.typicode.com/posts');
      const data = await res.json();
      this.setState({ posts: data });
    } catch (error) {
      this.setState({ error });
    }
  };

  componentDidMount() {
    this.loadPosts();
  }

  componentDidCatch(error, info) {
    alert('An error occurred: ' + error);
  }

  render() {
    const { posts, error } = this.state;
    if (error) return <p>Error loading posts.</p>;
    return (
      <div>
        <h1>Blog Posts</h1>
        {posts.slice(0,5).map(post => (
          <div key={post.id}>
            <h2>{post.title}</h2>
            <p>{post.body}</p>
          </div>
        ))}
      </div>
    );
  }
}

export default Posts;