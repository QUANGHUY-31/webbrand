document.getElementById("comment-form").addEventListener("submit", async function (e) {
    e.preventDefault();

    const name = document.getElementById("name").value;
    const email = document.getElementById("email").value;
    const message = document.getElementById("message").value;

    try {
        const res = await fetch("http://localhost:5022/api/comment", {
            method: "POST",
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify({
                name: name,
                email: email,
                message: message
            })
        });

        const data = await res.json();

        alert("Cảm ơn bạn đã gửi bình luận!");
        console.log(data);

    } catch (err) {
        console.error(err);
        alert("Lỗi server!");
    }
});